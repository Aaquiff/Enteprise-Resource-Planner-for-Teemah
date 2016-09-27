CREATE TABLE `salary` (
  `EmpId` int(11) NOT NULL,
  `NetSalary` double DEFAULT NULL,
  `GivenDate` date DEFAULT NULL,
  `Month` varchar(45) NOT NULL,
  PRIMARY KEY (`EmpId`,`Month`),
  KEY `EmpId_idx` (`EmpId`),
  CONSTRAINT `sal-EmpId` FOREIGN KEY (`EmpId`) REFERENCES `employee` (`EmpId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;