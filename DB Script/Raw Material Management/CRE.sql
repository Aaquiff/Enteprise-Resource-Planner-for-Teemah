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

CREATE TABLE `raw_item_tab` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(2000) NOT NULL,
  `description` varchar(2000) DEFAULT NULL,
  `stock_level` int(11) DEFAULT '0',
  `unit_of_measure` varchar(20) NOT NULL,
  `item_category` varchar(200) DEFAULT NULL,
  `bar_code` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

CREATE TABLE `raw_order_line_tab` (
  `order_id` varchar(200) NOT NULL,
  `item_id` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  `quantity` double NOT NULL,
  PRIMARY KEY (`order_id`,`item_id`),
  KEY `fkItemId_idx` (`item_id`),
  CONSTRAINT `fk_order_line_item` FOREIGN KEY (`item_id`) REFERENCES `raw_item_tab` (`item_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_purchase_order_tab` (
  `order_id` varchar(200) NOT NULL,
  `creation_date` date NOT NULL,
  `creator` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `approver` varchar(200) NOT NULL,
  `shipping_address` varchar(500) NOT NULL,
  `supplier_id` varchar(200) NOT NULL,
  `discount` double DEFAULT NULL,
  `notes` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_supplier_tab` (
  `supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(500) NOT NULL,
  `contact_person` varchar(200) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;




CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_order_line` AS (select `raw_order_line_tab`.`order_id` AS `order_id`,`raw_order_line_tab`.`item_id` AS `item_id`,`raw_order_line_tab`.`unit_price` AS `unit_price`,`raw_order_line_tab`.`quantity` AS `quantity`,`raw_item_tab`.`name` AS `item_name`,`raw_item_tab`.`unit_of_measure` AS `unit_of_measure`,(`raw_order_line_tab`.`quantity` * `raw_order_line_tab`.`unit_price`) AS `amount` from (`raw_order_line_tab` left join `raw_item_tab` on((`raw_order_line_tab`.`item_id` = `raw_item_tab`.`item_id`))));

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_purchase_order` AS (select `raw_purchase_order_tab`.`order_id` AS `order_id`,`raw_purchase_order_tab`.`creation_date` AS `creation_date`,`raw_purchase_order_tab`.`creator` AS `creator`,`raw_purchase_order_tab`.`status` AS `status`,`raw_purchase_order_tab`.`approver` AS `approver`,`raw_purchase_order_tab`.`shipping_address` AS `shipping_address`,`raw_purchase_order_tab`.`supplier_id` AS `supplier_id`,`raw_purchase_order_tab`.`notes` AS `notes`,`GET_SUPPLIER_NAME`(`raw_purchase_order_tab`.`supplier_id`) AS `supplier_name`,sum(`raw_order_line`.`amount`) AS `sub_total`,`raw_purchase_order_tab`.`discount` AS `discount`,(sum(`raw_order_line`.`amount`) - ((`raw_purchase_order_tab`.`discount` / 100) * sum(`raw_order_line`.`amount`))) AS `total` from (`raw_purchase_order_tab` left join `raw_order_line` on((`raw_purchase_order_tab`.`order_id` = `raw_order_line`.`order_id`))) group by `raw_purchase_order_tab`.`order_id`);



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
    set name = itemname_, 
    description = description_, 
    stock_level = stock_level_, 
    unit_of_measure = unit_of_measure_, 
    item_category = item_category_, 
    bar_code = bar_code_ 
    where item_id = itemid_;
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
		call `raise_error`('Cannot add items to orders not in state Created');
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAW_PURCHASE_ORDER_UPDATE`(
	IN order_id_ VARCHAR(20),
    IN shipping_address_ VARCHAR(20),
    IN supplier_id_ int(11),
    IN discount_ double,
    IN notes_ VARCHAR(2000)
)
BEGIN
	
    DECLARE order_status_ VARCHAR(200);
    
	
    SELECT status INTO order_status_ FROM raw_purchase_order_tab WHERE order_id = order_id_;
    
    IF(order_status_='Created') then
    
		UPDATE raw_purchase_order_tab
		SET shipping_address = shipping_address_,
		supplier_id = supplier_id_,
		discount = discount_,
        notes = notes_
		WHERE order_id = order_id_;	
    else
		call `raise_error`('Orders not in state Created cannot be updated');
	end if;
END$$
DELIMITER ;












