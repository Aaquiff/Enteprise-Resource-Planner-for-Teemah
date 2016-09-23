CREATE TABLE `user_tab` (
  `user` varchar(15) NOT NULL,
  `name` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`user`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `role_tab` (
  `role` varchar(200) NOT NULL,
  `description` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`role`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `user_role_tab` (
  `user` varchar(20) NOT NULL,
  `role` varchar(200) NOT NULL,
  PRIMARY KEY (`user`,`role`),
  KEY `fkUserRoleRole_idx` (`role`),
  CONSTRAINT `fkUserRoleRole` FOREIGN KEY (`role`) REFERENCES `role_tab` (`role`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fkUserRoleUser` FOREIGN KEY (`user`) REFERENCES `user_tab` (`user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `pan_message_tab` (
  `message_id` int(11) NOT NULL AUTO_INCREMENT,
  `to` varchar(45) DEFAULT NULL,
  `sender` varchar(45) DEFAULT NULL,
  `subject` varchar(45) DEFAULT NULL,
  `message` varchar(4000) DEFAULT NULL,
  PRIMARY KEY (`message_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;


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


CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user_role` AS select `user_role_tab`.`user` AS `user`,`user_role_tab`.`role` AS `role`,`role_tab`.`description` AS `description` from (`user_role_tab` join `role_tab` on((`user_role_tab`.`role` = `role_tab`.`role`)));

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user` AS select `ut`.`user` AS `user`,`ut`.`name` AS `name`,`mu`.`Password` AS `password` from (`user_tab` `ut` left join `mysql`.`user` `mu` on((convert(`ut`.`user` using utf8) = `mu`.`User`)));


/*
-- Query: SELECT * FROM itp.role_tab
LIMIT 0, 1000

-- Date: 2016-09-23 14:43
*/
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Administrator',NULL);
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Distribution Management User',NULL);
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Employee Management User','adfadadfad');
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Finance Management User',NULL);
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Finished Good Management User',NULL);
INSERT INTO `role_tab` (`role`,`description`) VALUES ('HR Manager',NULL);
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Product Process Management User',NULL);
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Raw Material Management User','');
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Raw Material Manager',NULL);
INSERT INTO `role_tab` (`role`,`description`) VALUES ('Sales Management User',NULL);
