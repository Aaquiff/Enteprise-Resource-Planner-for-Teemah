CREATE TABLE `user_role_tab` (
  `user` varchar(20) NOT NULL,
  `role` varchar(200) NOT NULL,
  PRIMARY KEY (`user`,`role`),
  KEY `fkUserRoleRole_idx` (`role`),
  CONSTRAINT `fkUserRoleRole` FOREIGN KEY (`role`) REFERENCES `role_tab` (`role`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fkUserRoleUser` FOREIGN KEY (`user`) REFERENCES `user_tab` (`user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user` AS select `ut`.`user` AS `user`,`ut`.`name` AS `name`,`mu`.`Password` AS `password` from (`itp`.`user_tab` `ut` left join `mysql`.`user` `mu` on((convert(`ut`.`user` using utf8) = `mu`.`User`)));

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user_role` AS select `user_role_tab`.`user` AS `user`,`user_role_tab`.`role` AS `role`,`role_tab`.`description` AS `description` from (`user_role_tab` join `role_tab` on((`user_role_tab`.`role` = `role_tab`.`role`)));

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
