DROP PROCEDURE IF EXISTS `CREATE_USER`;
DROP PROCEDURE IF EXISTS `DROP_USER`;

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