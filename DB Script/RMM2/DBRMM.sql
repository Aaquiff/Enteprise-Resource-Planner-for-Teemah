CREATE TABLE `raw_supplier_tab` (
  `supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(500) NOT NULL,
  `contact_person` varchar(200) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`),
  UNIQUE KEY `name` (`name`),
  UNIQUE KEY `phone` (`phone`),
  UNIQUE KEY `address` (`address`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=latin1;

CREATE TABLE `raw_item_tab` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(2000) NOT NULL,
  `description` varchar(2000) DEFAULT NULL,
  `stock_level` int(11) DEFAULT '0',
  `unit_of_measure` varchar(20) NOT NULL,
  `item_category` varchar(200) DEFAULT NULL,
  `bar_code` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1020 DEFAULT CHARSET=latin1;

CREATE TABLE `raw_settings_tab` (
  `setting` varchar(20) DEFAULT NULL,
  `value` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_purchase_order_tab` (
  `order_id` varchar(200) NOT NULL,
  `creation_date` date NOT NULL,
  `creator` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `approver` varchar(200) NOT NULL,
  `shipping_address` varchar(500) NOT NULL,
  `supplier_id` varchar(200) NOT NULL,
  `notes` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_order_line_tab` (
  `order_id` varchar(200) NOT NULL,
  `item_id` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  `quantity` double NOT NULL,
  PRIMARY KEY (`order_id`,`item_id`),
  KEY `fkItemId_idx` (`item_id`),
  CONSTRAINT `fk_order_line_item` FOREIGN KEY (`item_id`) REFERENCES `raw_item_tab` (`item_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_invoice_tab` (
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
  `currency` varchar(200) NOT NULL,
  PRIMARY KEY (`invoice_id`),
  KEY `fkInvoiceOrder_idx` (`order_id`),
  CONSTRAINT `fkInvoiceOrder` FOREIGN KEY (`order_id`) REFERENCES `raw_purchase_order_tab` (`order_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_currency_tab` (
  `currency` varchar(20) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`currency`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*CREATE TABLE `orders` (
  `orderId` int(11) NOT NULL AUTO_INCREMENT,
  `invoiceNo` varchar(20) NOT NULL,
  `orderDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `buyerId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unitPrice` double NOT NULL,
  `total` double NOT NULL,
  `shippingDate` varchar(15) NOT NULL,
  `empId` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`orderId`),
  UNIQUE KEY `fk_invoiceNum` (`productId`,`invoiceNo`),
  KEY `productId_idx` (`productId`),
  KEY `fk_buyerId_idx` (`buyerId`),
  KEY `fk_employeeId_idx` (`empId`),
  CONSTRAINT `fk_buyerId` FOREIGN KEY (`buyerId`) REFERENCES `buyer` (`buyerId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_employeeId` FOREIGN KEY (`empId`) REFERENCES `employee` (`EmpId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;*/


DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `GET_SUPPLIER_NAME`(supplier_id_ INT) RETURNS varchar(200) CHARSET latin1
BEGIN
	DECLARE supplier_name_ VARCHAR(200);
    
	SELECT name INTO supplier_name_ from raw_supplier_tab
    WHERE supplier_id = supplier_id_;
    
RETURN (supplier_name_);
END$$
DELIMITER ;


DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_INVOICE_DELETE`(
IN invoice_id_ VARCHAR(20)
)
BEGIN
	DELETE FROM raw_invoice_tab WHERE invoice_id = invoice_id_;
END$$
DELIMITER ;

DELIMITER $$
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

	INSERT INTO `raw_invoice_tab`
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
DELIMITER ;

DELIMITER $$
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
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_ITEM_INSERT`(
IN name_ VARCHAR(200),
IN description_ VARCHAR(200),
IN stock_level_ INT,
IN unit_of_measure_ VARCHAR(200),
IN item_category_ VARCHAR(200),
IN bar_code_ VARCHAR(200)
)
BEGIN
	if( stock_level_ < 0 ) then
		call RAISE_ERROR('Stock Level Cannot be less than zero');
    end if;
    
	insert into raw_item_tab 
    (name,description,stock_level,unit_of_measure,item_category,bar_code) 
    values (name_,description_,stock_level_,unit_of_measure_,item_category_,bar_code_);
    
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_ITEM_UPDATE`(
IN item_id_ INT,
IN name_ VARCHAR(200),
IN description_ VARCHAR(200),
IN stock_level_ INT,
IN unit_of_measure_ VARCHAR(200),
IN item_category_ VARCHAR(200),
IN bar_code_ VARCHAR(200)
)
BEGIN

	if( stock_level_ < 0 ) then
		call RAISE_ERROR('Stock Level Cannot be less than zero');
    end if;
	update raw_item_tab 
    set name = name_, 
    description = description_, 
    stock_level = stock_level_, 
    unit_of_measure = unit_of_measure_, 
    item_category = item_category_, 
    bar_code = bar_code_ 
    where item_id = item_id_;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_MATERIAL_ORDER_APPROVE`(
IN raw_material_request_id_ int
)
BEGIN
	declare item_id_ INT;
	declare item_name_ VARCHAR(20);
	declare quantity_required_ INT;
    declare quantity_available_ INT;
    declare status_ varchar(200);
    declare reorder_level_ varchar(200);
	declare message_ VARCHAR(2000);
    
    select status into status_ from rawmatreq where rawMatReqId = raw_material_request_id_;
    
    select quantity, productId INTO quantity_required_,item_id_ from rawmatreq where rawMatReqId = raw_material_request_id_;
    
    select stock_level,name into  quantity_available_,item_name_ from raw_item_tab where item_id = item_id_;
    
    if(status_ != 'Pending') then
		call RAISE_ERROR('Requests not in state Pending cannot be approved');
        
	elseif(quantity_available_ is null) then
		call raise_error('Item Not Found');
    
    elseif(quantity_available_ < quantity_required_) then
		call raise_error('Stocks Not available to cater the request');

    else
		update raw_item_tab 
		SET stock_level = stock_level - quantity_required_
		where item_id = item_id_;
		
		update rawmatreq SET status = 'Approved'
		where rawMatReqId = raw_material_request_id_;
		
		select COALESCE(CAST(value AS UNSIGNED),0) INTO reorder_level_ from raw_settings_tab where setting = 'REORDERLEVEL';
		

		if ( ( quantity_available_ - quantity_required_ ) <= reorder_level_ ) then
			INSERT INTO `pan_message_tab`
			(`to`,
			`sender`,
			`subject`,
			`message`)
			VALUES
			('ALL',
			'AUTOMATIC REORDER NOTIFIER',
			'REORDER THRESHOLD',
			CONCAT('This is a system generated message to inform that the item ',item_name_,' has fallen below the threshold limit of ',reorder_level_,'.'));

		end if;
    end if;
    commit;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_MATERIAL_ORDER_REJECT`(
IN raw_material_request_id_ int
)
BEGIN
	declare status_ varchar(200);
    
    select status into status_ from rawmatreq where rawMatReqId = raw_material_request_id_;
    
    if(status_ != 'Pending') then
		call RAISE_ERROR('Requests not in state Pending cannot be rejected');
	end if;
    
    update rawmatreq SET status = 'Rejected'
    where rawMatReqId = raw_material_request_id_;
    
    commit;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PUCHASE_ORDER_LINE_INSERT`(
	IN order_id_ VARCHAR(20),
    IN item_id_ INT(11),
    IN unit_price_ DOUBLE,
    IN quantity_ INT)
BEGIN
	DECLARE order_status_ VARCHAR(20);
    
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    if(order_status_ != 'Created') then
		call `raise_error`('Cannot add items to orders not in state Created');
	end if;
    if(unit_price_ < 0 ) then
		call `raise_error`('Unit Price Cannot Be Less Than 0');
	end if;
    
	INSERT INTO raw_order_line_tab
	(order_id, item_id, unit_price, quantity)
	VALUES        (order_id_, item_id_, unit_price_, quantity_);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_INSERT`(
	IN order_id_ VARCHAR(20),
    IN shipping_address_ VARCHAR(20),
    IN creator_ VARCHAR(20),
    IN supplier_id_ int(11),
    IN notes_ VARCHAR(2000)
)
BEGIN
	
    INSERT INTO raw_purchase_order_tab
                         (order_id, creation_date, creator, status, shipping_address, supplier_id, notes)
	VALUES        (order_id_, CURDATE(), creator_, 'Created', shipping_address_, supplier_id_, notes_);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_DELETE`(
	IN order_id_ VARCHAR(20)
)
BEGIN
	
    DELETE FROM raw_order_line_tab WHERE order_id = order_id_;
    DELETE FROM raw_purchase_order_tab WHERE order_id = order_id_;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_LINE_DELETE`(
	IN order_id_ VARCHAR(20),
    IN item_id_ INT(11)
    )
BEGIN
	DECLARE order_status_ VARCHAR(20);
    
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    if(order_status_ != 'Created') then
		call `raise_error`('Cannot delete items from orders not in state Created');
	end if;

	DELETE FROM raw_order_line_tab
	WHERE order_id = order_id_
    AND item_id = item_id_;
    
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_LINE_INSERT`(
	IN order_id_ VARCHAR(20),
    IN item_id_ INT(11),
    IN unit_price_ DOUBLE,
    IN quantity_ INT)
BEGIN
	DECLARE order_status_ VARCHAR(20);
    
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    if(order_status_ != 'Created') then
		call `raise_error`('Cannot add items to orders not in state Created');
	end if;
    if(unit_price_ < 0 ) then
		call `raise_error`('Unit Price Cannot Be Less Than 0');
	end if;
    
	INSERT INTO raw_order_line_tab
	(order_id, item_id, unit_price, quantity)
	VALUES        (order_id_, item_id_, unit_price_, quantity_);
END$$
DELIMITER ;

DELIMITER $$
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
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_STATUS_CHANGE`(
IN order_id_ VARCHAR(20),
IN to_status_ VARCHAR(200),
IN approver_ VARCHAR(200)
)
BEGIN
	DECLARE v_finished INTEGER DEFAULT 0;
    
	DECLARE status_ VARCHAR(200);
	DECLARE done INT DEFAULT FALSE;
    DECLARE item_id_ INT(11);
    DECLARE new_quantity_ INT(11);
    DECLARE quantity_ INT(11);
    DECLARE x INT;
    DECLARE cur1 CURSOR FOR SELECT item_id,quantity FROM raw_order_line_tab;
    DECLARE CONTINUE HANDLER 
        FOR NOT FOUND SET v_finished = 1;
    SELECT count(*) INTO x FROM user_role_tab WHERE user = approver_ and role = 'Raw Material Manager';
    if(x != 1) then
		call RAISE_ERROR('You are not auhtorized to change status');
    else
		select status into status_ from raw_purchase_order_tab where order_id = order_id_;
		if status_ = 'Created' and to_status_ = 'Approved' then
			update raw_purchase_order_tab set status = to_status_, approver = approver_ where order_id = order_id_;
			OPEN cur1;
			read_loop: LOOP
				FETCH cur1 INTO item_id_,new_quantity_;
				IF v_finished = 1 THEN
					LEAVE read_loop;
				END IF;
				SELECT stock_level INTO quantity_ FROM raw_item_tab WHERE item_id = item_id_;
				UPDATE raw_item_tab SET stock_level=quantity_+new_quantity_ WHERE item_id = item_id_;
			END LOOP;
			CLOSE cur1;
		elseif status_ = 'Created' and to_status_ = 'Cancelled' THEN
			update raw_purchase_order_tab 
			set status = to_status_,
			approver = approver_
			where order_id = order_id_;
		elseif status_ = 'Created' and to_status_ = 'Closed' THEN
			update raw_purchase_order_tab 
			set status = to_status_,
			approver = approver_
			where order_id = order_id_;
		else
			if( to_status_ = 'Cancelled' ) then
				call `raise_error`('Order Cannot Be Cancelled');
			elseif( to_status_ = 'Approved' ) then
				call `raise_error`('Order Cannot Be Approved');
			elseif( to_status_ = 'Closed' ) then
				call `raise_error`('Order Cannot Be Closed');
            end if;
		end if;
    end if;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_UPDATE`(
	IN order_id_ VARCHAR(20),
    IN shipping_address_ VARCHAR(20),
    IN supplier_id_ int(11),
    IN notes_ VARCHAR(2000)
)
BEGIN
	
    DECLARE order_status_ VARCHAR(200);
    
	
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    IF(order_status_='Created') then
    
		UPDATE raw_purchase_order_tab
		SET shipping_address = shipping_address_,
		supplier_id = supplier_id_,
        notes = notes_
		WHERE order_id = order_id_;	
    else
		call `raise_error`('Orders not in state Created cannot be updated');
	end if;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_SUPPLIER_INSERT`(
IN name_ VARCHAR(200),
IN contact_person_ VARCHAR(200),
IN phone_ VARCHAR(200),
IN address_ VARCHAR(200),
IN email_ VARCHAR(200)
)
BEGIN
	insert into raw_supplier_tab 
    (name,contact_person,phone,address,email) 
    values (name_,contact_person_,phone_,address_,email_);
    
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_SUPPLIER_UPDATE`(
IN supplier_id_ VARCHAR(20),
IN name_ VARCHAR(200),
IN contact_person_ VARCHAR(200),
IN phone_ VARCHAR(200),
IN address_ VARCHAR(200),
IN email_ VARCHAR(200)
)
BEGIN
	update raw_supplier_tab set name = name_, address = address_, phone = phone_, email = email_ where supplier_id = supplier_id_;
    
END$$
DELIMITER ;


CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_order_line` AS (select `raw_order_line_tab`.`order_id` AS `order_id`,`raw_order_line_tab`.`item_id` AS `item_id`,`raw_order_line_tab`.`unit_price` AS `unit_price`,`raw_order_line_tab`.`quantity` AS `quantity`,`raw_item_tab`.`name` AS `item_name`,`raw_item_tab`.`unit_of_measure` AS `unit_of_measure`,(`raw_order_line_tab`.`quantity` * `raw_order_line_tab`.`unit_price`) AS `amount` from (`raw_order_line_tab` left join `raw_item_tab` on((`raw_order_line_tab`.`item_id` = `raw_item_tab`.`item_id`))));

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_invoice` AS select `raw_invoice_tab`.`invoice_id` AS `invoice_id`,`raw_invoice_tab`.`order_id` AS `order_id`,`raw_invoice_tab`.`status` AS `status`,`raw_invoice_tab`.`date` AS `date`,`raw_invoice_tab`.`due_date` AS `due_date`,`raw_invoice_tab`.`original_due_date` AS `original_due_date`,`raw_invoice_tab`.`net_value` AS `net_value`,`raw_invoice_tab`.`tax_value` AS `tax_value`,`raw_invoice_tab`.`gross_value` AS `gross_value`,`raw_invoice_tab`.`discount` AS `discount`,`raw_invoice_tab`.`currency` AS `currency` from `raw_invoice_tab`;
/*
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `invoice` AS select `orders`.`invoiceNo` AS `invoiceNo`,`orders`.`orderDate` AS `orderDate`,`orders`.`shippingDate` AS `shippingDate`,`orders`.`buyerId` AS `buyerId`,sum(`orders`.`total`) AS `netTotal` from `orders` group by `orders`.`invoiceNo`;
*/
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_purchase_order` AS (select `raw_purchase_order_tab`.`order_id` AS `order_id`,`raw_purchase_order_tab`.`creation_date` AS `creation_date`,`raw_purchase_order_tab`.`creator` AS `creator`,`raw_purchase_order_tab`.`status` AS `status`,`raw_purchase_order_tab`.`approver` AS `approver`,`raw_purchase_order_tab`.`shipping_address` AS `shipping_address`,`raw_purchase_order_tab`.`supplier_id` AS `supplier_id`,`raw_purchase_order_tab`.`notes` AS `notes`,`GET_SUPPLIER_NAME`(`raw_purchase_order_tab`.`supplier_id`) AS `supplier_name`,sum(`raw_order_line`.`amount`) AS `sub_total` from (`raw_purchase_order_tab` left join `raw_order_line` on((`raw_purchase_order_tab`.`order_id` = `raw_order_line`.`order_id`))) group by `raw_purchase_order_tab`.`order_id`);
