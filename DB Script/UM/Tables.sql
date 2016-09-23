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
