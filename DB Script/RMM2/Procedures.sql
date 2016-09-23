DELIMITER $$
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
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DROP_USER`( IN user_id_ VARCHAR(15) )
BEGIN
	set @sql=concat("drop user '", user_id_ , "'@'localhost';");
	prepare stmt from @sql;
	execute stmt;
	deallocate prepare stmt;
    
    delete from user_tab where user = user_id_;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RAISE_ERROR`(`message` VARCHAR(256))
BEGIN
	SIGNAL SQLSTATE
		'ERR0R'
	SET
		MESSAGE_TEXT = `message`;
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

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `VALIDATE_EMAIL`(
IN email_ VARCHAR(2000))
BEGIN
	declare x int;
    set x = 0;
    
    select 1 into x from dual where 
    email_ REGEXP '^[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9._-]@[a-zA-Z0-9][a-zA-Z0-9._-]*[a-zA-Z0-9]\\.[a-zA-Z]{2,4}$';
    
    if(x!=0) then
		call RAISE_ERROR(x);
    else
		call RAISE_ERROR(x);
	end if;
END$$
DELIMITER ;
