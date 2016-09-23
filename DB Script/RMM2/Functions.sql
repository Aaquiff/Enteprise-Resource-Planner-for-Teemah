DELIMITER $$
CREATE DEFINER=`root`@`localhost` FUNCTION `GET_SUPPLIER_NAME`(supplier_id_ INT) RETURNS varchar(200) CHARSET latin1
BEGIN
	DECLARE supplier_name_ VARCHAR(200);
    
	SELECT name INTO supplier_name_ from raw_supplier_tab
    WHERE supplier_id = supplier_id_;
    
RETURN (supplier_name_);
END$$
DELIMITER ;
