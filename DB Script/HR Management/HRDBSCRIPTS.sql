--Creating tables for HRManagement

 CREATE TABLE `employee` (
  `EmpId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `NIC` char(10) DEFAULT NULL,
  `DOB` tinytext,
  `Nationality` varchar(20) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `MobileNo` char(15) DEFAULT NULL,
  `UserName` varchar(50) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `DepId` varchar(45) DEFAULT NULL,
  `Position` varchar(45) DEFAULT NULL,
  `BasicSalary` double DEFAULT NULL,
  PRIMARY KEY (`EmpId`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;


CREATE TABLE `leave` (
  `LeaveId` int(11) NOT NULL AUTO_INCREMENT,
  `EmpId` int(11) DEFAULT NULL,
  `RequestedDate` date DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Reason` varchar(75) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`LeaveId`),
  KEY `foreign_leave_idx` (`EmpId`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;


CREATE TABLE `salary` (
  `EmpId` int(11) NOT NULL,
  `NetSalary` double DEFAULT NULL,
  `GivenDate` date DEFAULT NULL,
  `Month` varchar(45) NOT NULL,
  PRIMARY KEY (`EmpId`,`Month`),
  KEY `EmpId_idx` (`EmpId`),
  CONSTRAINT `sal-EmpId` FOREIGN KEY (`EmpId`) REFERENCES `employee` (`EmpId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `ot` (
  `EmpId` int(11) NOT NULL,
  `OTHours` float DEFAULT NULL,
  `Month` varchar(45) NOT NULL,
  PRIMARY KEY (`EmpId`,`Month`),
  CONSTRAINT `ot-empid` FOREIGN KEY (`EmpId`) REFERENCES `employee` (`EmpId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


---------leave view-----------


CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `leave_view` AS select `leave`.`LeaveId` AS `LeaveId`,`leave`.`EmpId` AS `EmpId`,`leave`.`RequestedDate` AS `RequestedDate`,`leave`.`StartDate` AS `StartDate`,`leave`.`EndDate` AS `EndDate`,(to_days(`leave`.`EndDate`) - to_days(`leave`.`StartDate`)) AS `NoOfDays`,`leave`.`Type` AS `Type`,`leave`.`Reason` AS `Reason`,`leave`.`Status` AS `Status` from `leave`;



-----STORED PROCEDURE------
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `calcSalary`(IN _month varchar(30) )
BEGIN
	DECLARE v_finished INTEGER DEFAULT 0;
	declare eid int;
    declare ot float;
	declare bSal double;
    declare etf double;
    declare epf double;
    declare otTot double;
    declare net double;
    declare mon varchar(30);
    
    declare cur1 cursor for select EmpId,OTHours,Month from ot;
    DECLARE CONTINUE HANDLER 
        FOR NOT FOUND SET v_finished = 1;
        
    open cur1;
	read_loop: LOOP			
		FETCH cur1 INTO eid,ot,mon;
		IF v_finished = 1 THEN
					LEAVE read_loop;
		END IF;
        if mon = _month then
        
			select BasicSalary into bSal from employee where EmpId = eid;
			set otTot = (bSal / 240) * ot * 1.5;
			set etf = bSal * 0.03;
			set epf = bSal * 0.08;
			set net = (bSal + otTot) - (etf + epf);
			
			insert into salary(EmpId,NetSalary,GivenDate,Month)
			Values (eid,net,CURDATE(),mon);
		
        end if;
    end loop;
    close cur1;
END$$
DELIMITER ;
















--------Report View query--------

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `advancesalary` AS select `salary`.`Month` AS `Month`,sum(`salary`.`NetSalary`) AS `NetSalary` from `salary` group by `salary`.`Month`;







