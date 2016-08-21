--aaralk
-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 15, 2016 at 05:07 AM
-- Server version: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cdcol`
--

-- --------------------------------------------------------

--
-- Table structure for table `cds`
--

CREATE TABLE IF NOT EXISTS `cds` (
  `titel` varchar(200) COLLATE latin1_general_ci DEFAULT NULL,
  `interpret` varchar(200) COLLATE latin1_general_ci DEFAULT NULL,
  `jahr` int(11) DEFAULT NULL,
  `id` bigint(20) unsigned NOT NULL
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `cds`
--

INSERT INTO `cds` (`titel`, `interpret`, `jahr`, `id`) VALUES
('Beauty', 'Ryuichi Sakamoto', 1990, 1),
('Goodbye Country (Hello Nightclub)', 'Groove Armada', 2001, 4),
('Glee', 'Bran Van 3000', 1997, 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cds`
--
ALTER TABLE `cds`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cds`
--
ALTER TABLE `cds`
  MODIFY `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;--
-- Database: `itp`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `getMaterialReport`(IN `year_` INT, IN `month_` INT)
BEGIN

select p.item_id,i.item_name, SUM(p.unit) AS 'TOTAL_UNITS' ,SUM(total) AS 'TOTAL_AMOUNT'
from purchase_tab p,item_tab i
WHERE p.item_id = i.item_id
AND YEAR(p.date) = year_ AND MONTH(p.date) = month_
GROUP BY item_id;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `raise_error`(`errno` BIGINT UNSIGNED, `message` VARCHAR(256))
BEGIN
	SIGNAL SQLSTATE
		'ERR0R'
	SET
		MESSAGE_TEXT = `message`;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `raw_change_order_status`(
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
    
    DECLARE cur1 CURSOR FOR SELECT item_id,quantity FROM raw_order_line_tab;
    
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
		call `raise`('Order Cannot Be Approved');
    end if;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `raw_update_order_line`(
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
		call `raise_error`('0','Order Lines of Orders not in state Created cannot be updated');
	end if;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `raw_update_purchase_order`(
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
		call `raise_error`('0','Orders not in state Created cannot be updated');
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

-- --------------------------------------------------------

--
-- Table structure for table `raw_item_tab`
--

CREATE TABLE IF NOT EXISTS `raw_item_tab` (
  `item_id` int(11) NOT NULL,
  `name` varchar(2000) NOT NULL,
  `description` varchar(2000) NOT NULL,
  `stock_level` int(11) NOT NULL,
  `unit_of_measure` varchar(20) NOT NULL,
  `item_category` varchar(200) NOT NULL,
  `bar_code` varchar(200) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `raw_item_tab`
--

INSERT INTO `raw_item_tab` (`item_id`, `name`, `description`, `stock_level`, `unit_of_measure`, `item_category`, `bar_code`) VALUES
(2, 'Yeast High Suger ', '500g', 353, 'g', 'sfd', ''),
(3, 'Vanila', 'Ceylon Essence', 968, 'g', '', ''),
(4, 'Vanila Butter', 'Ceyolon Esse.', 772, 'g', '', ''),
(5, 'Amanda Cream Fat', '15 kg falcon', 3634, 'g', 'sfg', 'sfg');

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
('ORDER001', 2, 175.65, 10),
('ORDER001', 3, 250.3, 120),
('ORDER001', 4, 45, 245),
('ORDER001', 5, 1500, 1200),
('ORDER002', 3, 15, 195),
('ORDER003', 2, 15, 100),
('ORDER003', 4, 15, 1);

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
('ORDER001', '2016-08-12', 'AARALK', 'Approved', 'root', 'Colombo-025 adfaf', '3', 20),
('ORDER002', '2016-08-12', 'MIGULK', 'Created', 'root', 'Kandy', '3', 15),
('ORDER003', '2013-02-15', 'AARALK', 'Created', 'USRALK', 'Colombo', '3', 10),
('ORDER004', '2015-06-15', 'root', 'Cancelled', 'root', 'India', '1', 10);

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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `raw_supplier_tab`
--

INSERT INTO `raw_supplier_tab` (`supplier_id`, `name`, `contact_person`, `phone`, `address`, `email`) VALUES
(1, 'Supplier1', 'Nuwan', '077394528', '7,Newell Rd,London', 'nuwan@gmail.com'),
(2, 'Supplier 2', NULL, NULL, 'Colombo', 'haritha@yahoo.com'),
(3, 'Supplier3', 'jhakdjhf', '0112556985', 'Kandy', 'aaquiff@ymail.com');

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

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_purchase_order` AS (select `raw_purchase_order_tab`.`order_id` AS `order_id`,`raw_purchase_order_tab`.`creation_date` AS `creation_date`,`raw_purchase_order_tab`.`creator` AS `creator`,`raw_purchase_order_tab`.`status` AS `status`,`raw_purchase_order_tab`.`approver` AS `approver`,`raw_purchase_order_tab`.`shipping_address` AS `shipping_address`,`raw_purchase_order_tab`.`supplier_id` AS `supplier_id`,`GET_SUPPLIER_NAME`(`raw_purchase_order_tab`.`supplier_id`) AS `supplier_name`,sum(`raw_order_line`.`amount`) AS `sub_total`,`raw_purchase_order_tab`.`discount` AS `discount`,(sum(`raw_order_line`.`amount`) - ((`raw_purchase_order_tab`.`discount` / 100) * sum(`raw_order_line`.`amount`))) AS `total` from (`raw_purchase_order_tab` left join `raw_order_line` on((`raw_purchase_order_tab`.`order_id` = `raw_order_line`.`order_id`))) group by `raw_order_line`.`order_id`);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `raw_invoice_tab`
--
ALTER TABLE `raw_invoice_tab`
  ADD PRIMARY KEY (`invoice_id`);

--
-- Indexes for table `raw_item_tab`
--
ALTER TABLE `raw_item_tab`
  ADD PRIMARY KEY (`item_id`);

--
-- Indexes for table `raw_order_line_tab`
--
ALTER TABLE `raw_order_line_tab`
  ADD PRIMARY KEY (`order_id`,`item_id`);

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
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `raw_item_tab`
--
ALTER TABLE `raw_item_tab`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `raw_supplier_tab`
--
ALTER TABLE `raw_supplier_tab`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;--
-- Database: `phpmyadmin`
--

-- --------------------------------------------------------

--
-- Table structure for table `pma_bookmark`
--

CREATE TABLE IF NOT EXISTS `pma_bookmark` (
  `id` int(11) NOT NULL,
  `dbase` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `user` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `label` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `query` text COLLATE utf8_bin NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Bookmarks';

-- --------------------------------------------------------

--
-- Table structure for table `pma_column_info`
--

CREATE TABLE IF NOT EXISTS `pma_column_info` (
  `id` int(5) unsigned NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `column_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `comment` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `mimetype` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Column information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma_designer_coords`
--

CREATE TABLE IF NOT EXISTS `pma_designer_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `x` int(11) DEFAULT NULL,
  `y` int(11) DEFAULT NULL,
  `v` tinyint(4) DEFAULT NULL,
  `h` tinyint(4) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for Designer';

-- --------------------------------------------------------

--
-- Table structure for table `pma_history`
--

CREATE TABLE IF NOT EXISTS `pma_history` (
  `id` bigint(20) unsigned NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `sqlquery` text COLLATE utf8_bin NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='SQL history for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma_navigationhiding`
--

CREATE TABLE IF NOT EXISTS `pma_navigationhiding` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Hidden items of navigation tree';

-- --------------------------------------------------------

--
-- Table structure for table `pma_pdf_pages`
--

CREATE TABLE IF NOT EXISTS `pma_pdf_pages` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `page_nr` int(10) unsigned NOT NULL,
  `page_descr` varchar(50) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='PDF relation pages for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma_recent`
--

CREATE TABLE IF NOT EXISTS `pma_recent` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Recently accessed tables';

--
-- Dumping data for table `pma_recent`
--

INSERT INTO `pma_recent` (`username`, `tables`) VALUES
('root', '[{"db":"itp","table":"raw_order_line_tab"},{"db":"itp","table":"raw_item_tab"},{"db":"itp","table":"raw_order_line"},{"db":"itp","table":"raw_purchase_order"},{"db":"itp","table":"raw_purchase_order_tab"},{"db":"itp","table":"raw_orderline"},{"db":"itp","table":"raw_supplier_tab"},{"db":"itp","table":"raw_invoice_tab"},{"db":"itp","table":"supplier_tab"},{"db":"itp","table":"item_tab"}]');

-- --------------------------------------------------------

--
-- Table structure for table `pma_relation`
--

CREATE TABLE IF NOT EXISTS `pma_relation` (
  `master_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Relation table';

-- --------------------------------------------------------

--
-- Table structure for table `pma_savedsearches`
--

CREATE TABLE IF NOT EXISTS `pma_savedsearches` (
  `id` int(5) unsigned NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved searches';

-- --------------------------------------------------------

--
-- Table structure for table `pma_table_coords`
--

CREATE TABLE IF NOT EXISTS `pma_table_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `pdf_page_number` int(11) NOT NULL DEFAULT '0',
  `x` float unsigned NOT NULL DEFAULT '0',
  `y` float unsigned NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for phpMyAdmin PDF output';

-- --------------------------------------------------------

--
-- Table structure for table `pma_table_info`
--

CREATE TABLE IF NOT EXISTS `pma_table_info` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `display_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma_table_uiprefs`
--

CREATE TABLE IF NOT EXISTS `pma_table_uiprefs` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `prefs` text COLLATE utf8_bin NOT NULL,
  `last_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Tables'' UI preferences';

-- --------------------------------------------------------

--
-- Table structure for table `pma_tracking`
--

CREATE TABLE IF NOT EXISTS `pma_tracking` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `version` int(10) unsigned NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL,
  `schema_snapshot` text COLLATE utf8_bin NOT NULL,
  `schema_sql` text COLLATE utf8_bin,
  `data_sql` longtext COLLATE utf8_bin,
  `tracking` set('UPDATE','REPLACE','INSERT','DELETE','TRUNCATE','CREATE DATABASE','ALTER DATABASE','DROP DATABASE','CREATE TABLE','ALTER TABLE','RENAME TABLE','DROP TABLE','CREATE INDEX','DROP INDEX','CREATE VIEW','ALTER VIEW','DROP VIEW') COLLATE utf8_bin DEFAULT NULL,
  `tracking_active` int(1) unsigned NOT NULL DEFAULT '1'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin ROW_FORMAT=COMPACT COMMENT='Database changes tracking for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma_userconfig`
--

CREATE TABLE IF NOT EXISTS `pma_userconfig` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `config_data` text COLLATE utf8_bin NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User preferences storage for phpMyAdmin';

--
-- Dumping data for table `pma_userconfig`
--

INSERT INTO `pma_userconfig` (`username`, `timevalue`, `config_data`) VALUES
('root', '2016-06-21 12:47:59', '{"collation_connection":"utf8mb4_unicode_ci","ThemeDefault":"pmahomme"}');

-- --------------------------------------------------------

--
-- Table structure for table `pma_usergroups`
--

CREATE TABLE IF NOT EXISTS `pma_usergroups` (
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL,
  `tab` varchar(64) COLLATE utf8_bin NOT NULL,
  `allowed` enum('Y','N') COLLATE utf8_bin NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User groups with configured menu items';

-- --------------------------------------------------------

--
-- Table structure for table `pma_users`
--

CREATE TABLE IF NOT EXISTS `pma_users` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Users and their assignments to user groups';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pma_bookmark`
--
ALTER TABLE `pma_bookmark`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pma_column_info`
--
ALTER TABLE `pma_column_info`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `db_name` (`db_name`,`table_name`,`column_name`);

--
-- Indexes for table `pma_designer_coords`
--
ALTER TABLE `pma_designer_coords`
  ADD PRIMARY KEY (`db_name`,`table_name`);

--
-- Indexes for table `pma_history`
--
ALTER TABLE `pma_history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`,`db`,`table`,`timevalue`);

--
-- Indexes for table `pma_navigationhiding`
--
ALTER TABLE `pma_navigationhiding`
  ADD PRIMARY KEY (`username`,`item_name`,`item_type`,`db_name`,`table_name`);

--
-- Indexes for table `pma_pdf_pages`
--
ALTER TABLE `pma_pdf_pages`
  ADD PRIMARY KEY (`page_nr`),
  ADD KEY `db_name` (`db_name`);

--
-- Indexes for table `pma_recent`
--
ALTER TABLE `pma_recent`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma_relation`
--
ALTER TABLE `pma_relation`
  ADD PRIMARY KEY (`master_db`,`master_table`,`master_field`),
  ADD KEY `foreign_field` (`foreign_db`,`foreign_table`);

--
-- Indexes for table `pma_savedsearches`
--
ALTER TABLE `pma_savedsearches`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_savedsearches_username_dbname` (`username`,`db_name`,`search_name`);

--
-- Indexes for table `pma_table_coords`
--
ALTER TABLE `pma_table_coords`
  ADD PRIMARY KEY (`db_name`,`table_name`,`pdf_page_number`);

--
-- Indexes for table `pma_table_info`
--
ALTER TABLE `pma_table_info`
  ADD PRIMARY KEY (`db_name`,`table_name`);

--
-- Indexes for table `pma_table_uiprefs`
--
ALTER TABLE `pma_table_uiprefs`
  ADD PRIMARY KEY (`username`,`db_name`,`table_name`);

--
-- Indexes for table `pma_tracking`
--
ALTER TABLE `pma_tracking`
  ADD PRIMARY KEY (`db_name`,`table_name`,`version`);

--
-- Indexes for table `pma_userconfig`
--
ALTER TABLE `pma_userconfig`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma_usergroups`
--
ALTER TABLE `pma_usergroups`
  ADD PRIMARY KEY (`usergroup`,`tab`,`allowed`);

--
-- Indexes for table `pma_users`
--
ALTER TABLE `pma_users`
  ADD PRIMARY KEY (`username`,`usergroup`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pma_bookmark`
--
ALTER TABLE `pma_bookmark`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma_column_info`
--
ALTER TABLE `pma_column_info`
  MODIFY `id` int(5) unsigned NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma_history`
--
ALTER TABLE `pma_history`
  MODIFY `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma_pdf_pages`
--
ALTER TABLE `pma_pdf_pages`
  MODIFY `page_nr` int(10) unsigned NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma_savedsearches`
--
ALTER TABLE `pma_savedsearches`
  MODIFY `id` int(5) unsigned NOT NULL AUTO_INCREMENT;--
-- Database: `teemah`
--

-- --------------------------------------------------------

--
-- Table structure for table `invoice_tab`
--

CREATE TABLE IF NOT EXISTS `invoice_tab` (
  `invoice_id` varchar(20) NOT NULL,
  `supplier_id` varchar(20) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `item_tab`
--

CREATE TABLE IF NOT EXISTS `item_tab` (
  `item_id` varchar(20) NOT NULL,
  `item_name` varchar(200) NOT NULL,
  `description` varchar(2000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_tab`
--

CREATE TABLE IF NOT EXISTS `supplier_tab` (
  `supplier_id` varchar(20) NOT NULL,
  `supplier_name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `item_tab`
--
ALTER TABLE `item_tab`
  ADD PRIMARY KEY (`item_id`,`item_name`);

--
-- Indexes for table `supplier_tab`
--
ALTER TABLE `supplier_tab`
  ADD PRIMARY KEY (`supplier_id`);
--
-- Database: `test`
--
--
-- Database: `webauth`
--

-- --------------------------------------------------------

--
-- Table structure for table `user_pwd`
--

CREATE TABLE IF NOT EXISTS `user_pwd` (
  `name` char(30) COLLATE latin1_general_ci NOT NULL DEFAULT '',
  `pass` char(32) COLLATE latin1_general_ci NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `user_pwd`
--

INSERT INTO `user_pwd` (`name`, `pass`) VALUES
('xampp', 'wampp');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user_pwd`
--
ALTER TABLE `user_pwd`
  ADD PRIMARY KEY (`name`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
