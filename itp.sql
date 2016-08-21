-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 21, 2016 at 08:31 PM
-- Server version: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `itp`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `CREATE_USER`( IN user_id_ VARCHAR(15), IN password_ VARCHAR(200) , IN name_ VARCHAR(200))
BEGIN
	set @sql=concat("create user '", user_id_ ,"'@'localhost' identified by '",password_,"';");
	prepare stmt from @sql;
	execute stmt;
	deallocate prepare stmt;
    
    set @sql=concat("GRANT ALL PRIVILEGES ON itp.* TO'", user_id_ ,"'@'localhost' WITH GRANT OPTION;");
	prepare stmt from @sql;
	execute stmt;
	deallocate prepare stmt;

    
    INSERT INTO user_tab (user,name) VALUES (user_id_,name_) ;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DROP_USER`( IN user_id_ VARCHAR(15) )
BEGIN
	set @sql=concat("drop user '", user_id_ , "'@'localhost';");
	prepare stmt from @sql;
	execute stmt;
	deallocate prepare stmt;
    
    delete from user_tab where user = user_id_;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAISE_ERROR`(`message` VARCHAR(256))
BEGIN
	SIGNAL SQLSTATE
		'ERR0R'
	SET
		MESSAGE_TEXT = `message`;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_INVOICE_DELETE`(
IN invoice_id_ VARCHAR(20)
)
BEGIN
	DELETE FROM raw_invoice_tab WHERE invoice_id = invoice_id_;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_INVOICE_INSERT`(
IN invoice_id_ VARCHAR(20),
IN order_id_ VARCHAR(20),
IN due_date_ DATE,
IN original_due_date_ DATE,
IN net_value_ DOUBLE,
IN tax_value_ DOUBLE,
IN gross_value_ DOUBLE,
IN discount_ INT(11),
IN currency_ VARCHAR(200)
)
BEGIN

	INSERT INTO `itp`.`raw_invoice_tab`
	(`invoice_id`,
	`order_id`,
	`status`,
	`date`,
	`due_date`,
	`original_due_date`,
	`net_value`,
	`tax_value`,
	`gross_value`,
	`discount`,
	`currency`)
	VALUES
	(invoice_id_,
	order_id_,
	'Created',
	CURDATE(),
	due_date_,
	original_due_date_,
	net_value_,
	tax_value_,
	gross_value_,
	discount_,
	currency_);

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_INVOICE_UPDATE`(
IN invoice_id_ VARCHAR(20),
IN order_id_ VARCHAR(20),
IN due_date_ DATE,
IN original_due_date_ DATE,
IN net_value_ DOUBLE,
IN tax_value_ DOUBLE,
IN gross_value_ DOUBLE,
IN discount_ INT(11),
IN currency_ VARCHAR(200)
)
BEGIN
	UPDATE raw_invoice_tab SET
    order_id = order_id_,
    due_date = due_date_,
    original_due_date = original_due_date_,
    net_value = net_value_,
    tax_value = tax_value_,
    gross_value = gross_value_,
    discount = discount_,
    currency = currency_
    WHERE invoice_id = invoice_id_;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PUCHASE_ORDER_LINE_INSERT`(
	IN order_id_ VARCHAR(20),
    IN item_id_ INT(11),
    IN unit_price_ DOUBLE,
    IN quantity_ INT)
BEGIN
	DECLARE order_status_ VARCHAR(20);
    
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    if(order_status_ = 'Created') then
		INSERT INTO raw_order_line_tab
		(order_id, item_id, unit_price, quantity)
		VALUES        (order_id_, item_id_, unit_price_, quantity_);
    else
		call `raise_error`('Cannot add items to orders not in state Created');
        end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PUCHASE_ORDER_STATUS_CHANGE`(
IN order_id_ VARCHAR(20),
IN to_status_ VARCHAR(200),
IN approver_ VARCHAR(200)
)
BEGIN
	DECLARE status_ VARCHAR(200);
	DECLARE done INT DEFAULT FALSE;
    DECLARE item_id_ INT(11);
    DECLARE new_quantity_ INT(11);
    DECLARE quantity_ INT(11);
    
    DECLARE x INT;
    
    DECLARE cur1 CURSOR FOR SELECT item_id,quantity FROM raw_order_line_tab;
    
    SELECT 1 INTO x FROM user_role_tab WHERE user = approver_ and role = 'Raw Material Manager';
    
    if(x != 1) then
	call RAISE_ERROR('You are not auhtorized to change status');
    
    else
    
		select status into status_ from raw_purchase_order_tab
		where order_id = order_id_;
		
		if status_ = 'Created' and to_status_ = 'Approved' then
			update raw_purchase_order_tab 
			set status = to_status_,
			approver = approver_
			where order_id = order_id_;
			
			OPEN cur1;
			read_loop: LOOP
				FETCH cur1 INTO item_id_,new_quantity_;
			IF done THEN
				LEAVE read_loop;
			END IF;
				SELECT stock_level INTO quantity_ FROM raw_item_tab WHERE item_id = item_id_;
				
				UPDATE raw_item_tab
				SET stock_level=quantity_+new_quantity_
				WHERE item_id = item_id_;
				
			END LOOP;
			
			CLOSE cur1;
		elseif to_status_ = 'Cancelled' THEN
			update raw_purchase_order_tab 
			set status = to_status_,
			approver = approver_
			where order_id = order_id_;
		else
			call `raise_error`('Order in status'|| status_ ||'Cannot Be Approved');
		end if;
    end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_LINE_INSERT`(
	IN order_id_ VARCHAR(20),
    IN item_id_ INT(11),
    IN unit_price_ DOUBLE,
    IN quantity_ INT)
BEGIN
	DECLARE order_status_ VARCHAR(20);
    
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    if(order_status_ = 'Created') then
		INSERT INTO raw_order_line_tab
		(order_id, item_id, unit_price, quantity)
		VALUES        (order_id_, item_id_, unit_price_, quantity_);
    else
		call `raise_error`('Cannot add items to orders not in state Created');
        end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_LINE_UPDATE`(
	IN order_id_ VARCHAR(20),
    IN item_id_ INT(11),
    IN unit_price_ DOUBLE,
    IN quantity_ INT
    )
BEGIN
	
    DECLARE order_status_ VARCHAR(20);
    
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
	
    IF ( order_status_ = 'Created' ) THEN
		
		UPDATE       raw_order_line_tab
		SET                unit_price = unit_price_, quantity = quantity_
		WHERE        (order_id = order_id_) AND (item_id = item_id_);
	ELSE
		call `raise_error`('Order Lines of Orders not in state Created cannot be updated');
	end if;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_UPDATE`(
	IN order_id_ VARCHAR(20),
    IN shipping_address_ VARCHAR(20),
    IN supplier_id_ int(11),
    IN discount_ double
)
BEGIN
	
    DECLARE order_status_ VARCHAR(200);
    
	
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    IF(order_status_='Created') then
    
		UPDATE raw_purchase_order_tab
		SET shipping_address = shipping_address_,
		supplier_id = supplier_id_,
		discount = discount_
		WHERE order_id = order_id_;	
    else
		call `raise_error`('Orders not in state Created cannot be updated');
	end if;
END$$

--
-- Functions
--
CREATE DEFINER=`root`@`localhost` FUNCTION `get_supplier_name`(supplier_id_ INT) RETURNS varchar(200) CHARSET latin1
BEGIN
	DECLARE supplier_name_ VARCHAR(200);
    
	SELECT name INTO supplier_name_ from raw_supplier_tab
    WHERE supplier_id = supplier_id_;
    
RETURN (supplier_name_);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE IF NOT EXISTS `employee` (
  `EmpId` char(6) NOT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `NIC` char(10) DEFAULT NULL,
  `DOB` tinytext,
  `Nationality` varchar(20) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `MobileNo` int(11) DEFAULT NULL,
  `UserName` varchar(50) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `DepId` varchar(45) DEFAULT NULL,
  `Position` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EmpId`, `FirstName`, `LastName`, `Gender`, `Address`, `NIC`, `DOB`, `Nationality`, `Email`, `MobileNo`, `UserName`, `Password`, `DepId`, `Position`) VALUES
('001', 'jane', 'hjgbhfiehi', 'F', 'yaaaahoooo', '867501931V', '01 June 1920', 'Srilankan', 'djfbblrguhr', 717257232, 'SR1Sam', '1234', 'Service', 'Employee'),
('002', 'Jenny', 'John', 'F', '6,Rohini Road,Colombo-6', '957501931V', '06 September 1995', 'Srilankan', 'jenny@gmail.com', 777760477, 'HR2Jenny', '1234', 'HR', 'HR Manager'),
('004', 'amma', 'appa', 'F', '8,Galle Road,Colombo', '957501931v', '12 August 2016', 'indian', 'kiru@hahoo.com', 777760477, NULL, NULL, 'Human Resource', 'Employee'),
('005', 'hgk', 'ugy', 'F', 'matale', '589624583v', '12 August 2016', 'kjglui', 'jfurhgui@fjbhvu', 756757221, NULL, NULL, 'Distribution', 'Driver'),
('006', 'abhi', 'ravi', 'F', 'kandy', '857501931v', '12 August 2016', 'british', 'abhi@hotmail.com', 717257232, 'SR6abhi', '1234', 'Service', 'Employee'),
('007', ' ashwin', 'bala', 'M', ' Colombo', '991501331V', '03 November 1999', ' South African', 'nfs@gmail.com ', 717257232, NULL, NULL, 'Service', 'Employee'),
('008', ' thth', 'hjygj', 'M', ' uyfku', '957501931V', '06 September 1995', ' gykfgki', 'hjgygugu', 777760777, NULL, NULL, 'Distribution', 'Driver'),
('009', ' Kesha ', 'Rajan', 'F', ' Bamba', '958431967V', '06 September 1995', ' Chinese', 'keshar@gmail.com', 775772157, 'SR9Kesha ', '1234', 'Service', 'Employee'),
('010', ' Bill', 'Bong', 'M', ' Angoda', '847532145V', '06 September 1995', ' grgrrgr', 'ilgygigyugu', 717257232, 'SL10 Bill', '1234', 'Sales', 'Sales Manager'),
('11', ' ruban', 'nanthaagopal', 'M', ' colombo', '952244224V', '31 August 1995', ' Srilankan', 'ruban@gmail.com', 777745862, 'FM11 ruban', '1234', 'Finance', 'Finance Manager');

-- --------------------------------------------------------

--
-- Table structure for table `leave`
--

CREATE TABLE IF NOT EXISTS `leave` (
  `LeaveId` int(11) NOT NULL,
  `EmpId` char(6) DEFAULT NULL,
  `RequestedDate` tinytext,
  `StartDate` tinytext,
  `EndDate` tinytext,
  `NoOfDays` int(11) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Reason` varchar(75) DEFAULT NULL,
  `Status` int(11) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `leave`
--

INSERT INTO `leave` (`LeaveId`, `EmpId`, `RequestedDate`, `StartDate`, `EndDate`, `NoOfDays`, `Type`, `Reason`, `Status`) VALUES
(1, '001', '01 August 2016', '25 August 2016', '28 August 2016', 4, 'Annual', 'Have to study for MSc', 1),
(2, '006', '31 July 2016', '01 August 2016', '01 August 2016', 1, 'Sick', 'Fever', 1);

-- --------------------------------------------------------

--
-- Table structure for table `raw_invoice_tab`
--

CREATE TABLE IF NOT EXISTS `raw_invoice_tab` (
  `invoice_id` varchar(200) NOT NULL,
  `order_id` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `date` date NOT NULL,
  `due_date` date NOT NULL,
  `original_due_date` date NOT NULL,
  `net_value` double NOT NULL,
  `tax_value` double NOT NULL,
  `gross_value` double NOT NULL,
  `discount` int(11) NOT NULL,
  `currency` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `raw_invoice_tab`
--

INSERT INTO `raw_invoice_tab` (`invoice_id`, `order_id`, `status`, `date`, `due_date`, `original_due_date`, `net_value`, `tax_value`, `gross_value`, `discount`, `currency`) VALUES
('INV001', 'ORDER007', 'Created', '2016-08-18', '2015-01-12', '2015-05-23', 341, 34, 34, 343, 'SLR'),
('INV002', 'ORDER003', 'Created', '2016-08-19', '2019-05-23', '2018-05-02', 34, 12, 23, 2, 'Dollar'),
('INV003', 'ORDER006', 'Created', '2016-08-19', '2015-01-16', '2015-05-28', 34, 34, 342, 23, '$'),
('INV004', 'ORDER006', 'Created', '2016-08-20', '2020-05-23', '2015-01-12', 66, 16, 16, 10, '$'),
('INV005', 'ORDER003', 'Created', '2016-08-20', '2026-05-23', '2016-12-01', 125, 1251, 215, 215, '$');

-- --------------------------------------------------------

--
-- Table structure for table `raw_item_tab`
--

CREATE TABLE IF NOT EXISTS `raw_item_tab` (
  `item_id` int(11) NOT NULL,
  `name` varchar(2000) NOT NULL,
  `description` varchar(2000) DEFAULT NULL,
  `stock_level` int(11) DEFAULT '0',
  `unit_of_measure` varchar(20) NOT NULL,
  `item_category` varchar(200) DEFAULT NULL,
  `bar_code` varchar(200) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `raw_item_tab`
--

INSERT INTO `raw_item_tab` (`item_id`, `name`, `description`, `stock_level`, `unit_of_measure`, `item_category`, `bar_code`) VALUES
(2, 'Yeast High Suger ', '500g', 473, 'g', 'sfd', ''),
(3, 'Vanila', 'Ceylon Essence', 968, 'g', 't', ''),
(5, 'Amanda Cream Fat', '15 kg falcon', 3659, 'g', 'sfg', 'sfg'),
(7, 'Item7', 'adfadfadf', NULL, 'ml', NULL, NULL),
(8, 'Item8', NULL, NULL, 'ml', NULL, NULL);

-- --------------------------------------------------------

--
-- Stand-in structure for view `raw_order_line`
--
CREATE TABLE IF NOT EXISTS `raw_order_line` (
`order_id` varchar(200)
,`item_id` int(11)
,`unit_price` double
,`quantity` double
,`item_name` varchar(2000)
,`unit_of_measure` varchar(20)
,`amount` double
);

-- --------------------------------------------------------

--
-- Table structure for table `raw_order_line_tab`
--

CREATE TABLE IF NOT EXISTS `raw_order_line_tab` (
  `order_id` varchar(200) NOT NULL,
  `item_id` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  `quantity` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `raw_order_line_tab`
--

INSERT INTO `raw_order_line_tab` (`order_id`, `item_id`, `unit_price`, `quantity`) VALUES
('ORDER001', 2, 150, 10),
('ORDER001', 8, 15, 100),
('ORDER006', 2, 10, 15),
('ORDER008', 2, 15, 10),
('ORDER008', 5, 15, 12),
('ORDER008', 7, 150, 10),
('ORDER008', 8, 342, 10);

-- --------------------------------------------------------

--
-- Stand-in structure for view `raw_purchase_order`
--
CREATE TABLE IF NOT EXISTS `raw_purchase_order` (
`order_id` varchar(200)
,`creation_date` date
,`creator` varchar(200)
,`status` varchar(200)
,`approver` varchar(200)
,`shipping_address` varchar(500)
,`supplier_id` varchar(200)
,`supplier_name` varchar(200)
,`sub_total` double
,`discount` double
,`total` double
);

-- --------------------------------------------------------

--
-- Table structure for table `raw_purchase_order_tab`
--

CREATE TABLE IF NOT EXISTS `raw_purchase_order_tab` (
  `order_id` varchar(200) NOT NULL,
  `creation_date` date NOT NULL,
  `creator` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `approver` varchar(200) NOT NULL,
  `shipping_address` varchar(500) NOT NULL,
  `supplier_id` varchar(200) NOT NULL,
  `discount` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `raw_purchase_order_tab`
--

INSERT INTO `raw_purchase_order_tab` (`order_id`, `creation_date`, `creator`, `status`, `approver`, `shipping_address`, `supplier_id`, `discount`) VALUES
('ORDER001', '2016-08-16', 'root', 'Approved', 'root', 'Matara', '4', 15),
('ORDER003', '2016-08-16', 'root', 'Approved', 'root', 'Colombo', '3', 10),
('ORDER005', '2016-08-16', 'root', 'Approved', 'root', 'adfadf', '3', 23),
('ORDER006', '2016-08-16', 'root', 'Cancelled', 'root', 'jadfa', '3', 20),
('ORDER007', '2016-08-17', 'root', 'Approved', 'Aaquiff', 'Matara', '3', 20),
('ORDER008', '2016-08-18', 'root', 'Approved', 'Aaquiff', 'Matara123', '5', 12),
('ORDER009', '2016-08-21', 'Aaquiff', 'Created', '', 'Delaware', '8', 18);

-- --------------------------------------------------------

--
-- Table structure for table `raw_supplier_tab`
--

CREATE TABLE IF NOT EXISTS `raw_supplier_tab` (
  `supplier_id` int(11) NOT NULL,
  `name` varchar(500) NOT NULL,
  `contact_person` varchar(200) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `raw_supplier_tab`
--

INSERT INTO `raw_supplier_tab` (`supplier_id`, `name`, `contact_person`, `phone`, `address`, `email`) VALUES
(2, 'Supplier 2', NULL, NULL, 'Colombo', 'haritha@yahoo.com'),
(3, 'Supplier3', 'jhakdjhf', '0112556985', 'Kandy', 'aaquiff@ymail.com'),
(4, 'Supplier4', NULL, NULL, 'Matara', NULL),
(5, 'Supplier5', NULL, 'hjfjfhj', NULL, 'dafad'),
(6, 'Supplier6', 'Indra', '6416156', 'adfa', 'adfadf'),
(7, 'Supplier8', 'adfjh', '6531454', 'adfadf', NULL),
(8, 'Supplier 9 ', 'adf', '51645', NULL, 'fcdf'),
(9, 'Supplier 10', 'jndaljfn', '55155', 'anfjd', 'lanfljadnl');

-- --------------------------------------------------------

--
-- Table structure for table `role_tab`
--

CREATE TABLE IF NOT EXISTS `role_tab` (
  `role` varchar(200) NOT NULL,
  `description` varchar(2000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role_tab`
--

INSERT INTO `role_tab` (`role`, `description`) VALUES
('Administrator', 'Administrative Employee'),
('Distribution Management User', NULL),
('Employee Management User', NULL),
('Finance Management User', NULL),
('Finance Manager', NULL),
('Finished Good Management User', NULL),
('HR Manager', 'Human Resources Manager'),
('Product Process Management User', NULL),
('Raw Material Management User', NULL),
('Raw Material Manager', 'Can change order states'),
('Sales Management User', NULL);

-- --------------------------------------------------------

--
-- Stand-in structure for view `user`
--
CREATE TABLE IF NOT EXISTS `user` (
`user` varchar(15)
,`name` varchar(200)
,`password` char(41)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `user_role`
--
CREATE TABLE IF NOT EXISTS `user_role` (
`user` varchar(20)
,`role` varchar(200)
,`description` varchar(2000)
);

-- --------------------------------------------------------

--
-- Table structure for table `user_role_tab`
--

CREATE TABLE IF NOT EXISTS `user_role_tab` (
  `user` varchar(20) NOT NULL,
  `role` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_role_tab`
--

INSERT INTO `user_role_tab` (`user`, `role`) VALUES
('aaralk', 'Administrator'),
('aaralk', 'Distribution Management User'),
('aaralk', 'Employee Management User'),
('aaralk', 'Finance Management User'),
('aaralk', 'Finance Manager'),
('aaralk', 'Finished Good Management User'),
('aaralk', 'HR Manager'),
('aaralk', 'Product Process Management User'),
('aaralk', 'Raw Material Management User'),
('aaralk', 'Raw Material Manager'),
('aaralk', 'Sales Management User');

-- --------------------------------------------------------

--
-- Table structure for table `user_tab`
--

CREATE TABLE IF NOT EXISTS `user_tab` (
  `user` varchar(15) NOT NULL,
  `name` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_tab`
--

INSERT INTO `user_tab` (`user`, `name`) VALUES
('aaq', 'aaq'),
('aaralk', 'Aaquiff'),
('aaralk2', 'Aaquiff23'),
('aaralk3', 'Rauff'),
('kiru', 'kirukalutaha'),
('wick', 'wicky');

-- --------------------------------------------------------

--
-- Structure for view `raw_order_line`
--
DROP TABLE IF EXISTS `raw_order_line`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_order_line` AS (select `raw_order_line_tab`.`order_id` AS `order_id`,`raw_order_line_tab`.`item_id` AS `item_id`,`raw_order_line_tab`.`unit_price` AS `unit_price`,`raw_order_line_tab`.`quantity` AS `quantity`,`raw_item_tab`.`name` AS `item_name`,`raw_item_tab`.`unit_of_measure` AS `unit_of_measure`,(`raw_order_line_tab`.`quantity` * `raw_order_line_tab`.`unit_price`) AS `amount` from (`raw_order_line_tab` left join `raw_item_tab` on((`raw_order_line_tab`.`item_id` = `raw_item_tab`.`item_id`))));

-- --------------------------------------------------------

--
-- Structure for view `raw_purchase_order`
--
DROP TABLE IF EXISTS `raw_purchase_order`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_purchase_order` AS (select `raw_purchase_order_tab`.`order_id` AS `order_id`,`raw_purchase_order_tab`.`creation_date` AS `creation_date`,`raw_purchase_order_tab`.`creator` AS `creator`,`raw_purchase_order_tab`.`status` AS `status`,`raw_purchase_order_tab`.`approver` AS `approver`,`raw_purchase_order_tab`.`shipping_address` AS `shipping_address`,`raw_purchase_order_tab`.`supplier_id` AS `supplier_id`,`GET_SUPPLIER_NAME`(`raw_purchase_order_tab`.`supplier_id`) AS `supplier_name`,sum(`raw_order_line`.`amount`) AS `sub_total`,`raw_purchase_order_tab`.`discount` AS `discount`,(sum(`raw_order_line`.`amount`) - ((`raw_purchase_order_tab`.`discount` / 100) * sum(`raw_order_line`.`amount`))) AS `total` from (`raw_purchase_order_tab` left join `raw_order_line` on((`raw_purchase_order_tab`.`order_id` = `raw_order_line`.`order_id`))) group by `raw_purchase_order_tab`.`order_id`);

-- --------------------------------------------------------

--
-- Structure for view `user`
--
DROP TABLE IF EXISTS `user`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user` AS select `ut`.`user` AS `user`,`ut`.`name` AS `name`,`mu`.`Password` AS `password` from (`user_tab` `ut` left join `mysql`.`user` `mu` on((convert(`ut`.`user` using utf8) = `mu`.`User`)));

-- --------------------------------------------------------

--
-- Structure for view `user_role`
--
DROP TABLE IF EXISTS `user_role`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user_role` AS select `user_role_tab`.`user` AS `user`,`user_role_tab`.`role` AS `role`,`role_tab`.`description` AS `description` from (`user_role_tab` join `role_tab` on((`user_role_tab`.`role` = `role_tab`.`role`)));

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmpId`),
  ADD UNIQUE KEY `EmpId_UNIQUE` (`EmpId`);

--
-- Indexes for table `leave`
--
ALTER TABLE `leave`
  ADD PRIMARY KEY (`LeaveId`),
  ADD KEY `EmpId` (`EmpId`);

--
-- Indexes for table `raw_invoice_tab`
--
ALTER TABLE `raw_invoice_tab`
  ADD PRIMARY KEY (`invoice_id`),
  ADD KEY `fkInvoiceOrder_idx` (`order_id`);

--
-- Indexes for table `raw_item_tab`
--
ALTER TABLE `raw_item_tab`
  ADD PRIMARY KEY (`item_id`);

--
-- Indexes for table `raw_order_line_tab`
--
ALTER TABLE `raw_order_line_tab`
  ADD PRIMARY KEY (`order_id`,`item_id`),
  ADD KEY `fkItemId_idx` (`item_id`);

--
-- Indexes for table `raw_purchase_order_tab`
--
ALTER TABLE `raw_purchase_order_tab`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `raw_supplier_tab`
--
ALTER TABLE `raw_supplier_tab`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `role_tab`
--
ALTER TABLE `role_tab`
  ADD PRIMARY KEY (`role`);

--
-- Indexes for table `user_role_tab`
--
ALTER TABLE `user_role_tab`
  ADD PRIMARY KEY (`user`,`role`),
  ADD KEY `fkUserRoleRole_idx` (`role`);

--
-- Indexes for table `user_tab`
--
ALTER TABLE `user_tab`
  ADD PRIMARY KEY (`user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `leave`
--
ALTER TABLE `leave`
  MODIFY `LeaveId` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `raw_item_tab`
--
ALTER TABLE `raw_item_tab`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `raw_supplier_tab`
--
ALTER TABLE `raw_supplier_tab`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `leave`
--
ALTER TABLE `leave`
  ADD CONSTRAINT `leave_ibfk_1` FOREIGN KEY (`EmpId`) REFERENCES `employee` (`EmpId`),
  ADD CONSTRAINT `leave_ibfk_2` FOREIGN KEY (`EmpId`) REFERENCES `employee` (`EmpId`);

--
-- Constraints for table `raw_invoice_tab`
--
ALTER TABLE `raw_invoice_tab`
  ADD CONSTRAINT `fkInvoiceOrder` FOREIGN KEY (`order_id`) REFERENCES `raw_purchase_order_tab` (`order_id`) ON UPDATE CASCADE;

--
-- Constraints for table `raw_order_line_tab`
--
ALTER TABLE `raw_order_line_tab`
  ADD CONSTRAINT `fk_order_line_item` FOREIGN KEY (`item_id`) REFERENCES `raw_item_tab` (`item_id`) ON UPDATE CASCADE;

--
-- Constraints for table `user_role_tab`
--
ALTER TABLE `user_role_tab`
  ADD CONSTRAINT `fkUserRoleRole` FOREIGN KEY (`role`) REFERENCES `role_tab` (`role`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fkUserRoleUser` FOREIGN KEY (`user`) REFERENCES `user_tab` (`user`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
