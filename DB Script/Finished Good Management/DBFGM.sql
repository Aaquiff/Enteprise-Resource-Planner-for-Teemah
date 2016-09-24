CREATE TABLE `products` (
  `productId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  `notes` varchar(256) DEFAULT NULL,
  `weight` int(11) DEFAULT NULL,
  PRIMARY KEY (`productId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	

CREATE TABLE `orders` (
  `orderId` int(11) NOT NULL AUTO_INCREMENT,
  `invoiceNo` varchar(20) NOT NULL,
  `orderDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `buyerId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unitPrice` double NOT NULL,
  `total` double NOT NULL,
  `shippingDate` varchar(15) NOT NULL,
  `empId` int(11) DEFAULT NULL,
  `status` varchar(45) DEFAULT 'Pending',
  PRIMARY KEY (`orderId`),
  UNIQUE KEY `fk_invoiceNum` (`productId`,`invoiceNo`),
  KEY `productId_idx` (`productId`),
  KEY `fk_buyerId_idx` (`buyerId`),
  KEY `fk_employeeId_idx` (`empId`),
  CONSTRAINT `FK_EmpID` FOREIGN KEY (`empId`) REFERENCES `employee` (`EmpId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ProductId` FOREIGN KEY (`productId`) REFERENCES `products` (`productId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_buyerId` FOREIGN KEY (`buyerId`) REFERENCES `buyer` (`buyerId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	
 CREATE TABLE `inv_productreq` (
  `productReqId` int(11) NOT NULL AUTO_INCREMENT,
  `productId` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `requestDate` date DEFAULT NULL,
  `orderDate` date DEFAULT NULL,
  `status` varchar(32) DEFAULT 'Pending',
  `notes` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`productReqId`),
  KEY `productId_idx` (`productId`),
  CONSTRAINT `productId` FOREIGN KEY (`productId`) REFERENCES `products` (`productId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2342 DEFAULT CHARSET=utf8;

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	

CREATE TABLE `inv_newitems` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ReceivedDate` varchar(30) DEFAULT NULL,
  `BatchNo` int(11) DEFAULT NULL,
  `ManufacturedDate` varchar(30) DEFAULT NULL,
  `ExpiredDate` varchar(30) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `ProductName` varchar(50) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `MaximumRetailPrice` double DEFAULT NULL,
  `UnitPrice` int(11) DEFAULT NULL,
  `Packed` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `productId_idx` (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
SELECT * FROM inv_itp.inv_newitems;
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	


CREATE TABLE `inv_inventoryout` (
  `orderid` int(11) NOT NULL AUTO_INCREMENT,
  `orderdate` varchar(45) DEFAULT NULL,
  `deliverydate` varchar(45) DEFAULT NULL,
  `productid` int(11) DEFAULT NULL,
  `productname` varchar(45) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `maximumretailprice` int(11) DEFAULT NULL,
  `unitprice` int(11) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`orderid`)
) ENGINE=InnoDB AUTO_INCREMENT=23227 DEFAULT CHARSET=utf8;


>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	

CREATE TABLE `buyer` (
  `buyerId` int(11) NOT NULL AUTO_INCREMENT,
  `storeName` varchar(60) NOT NULL,
  `contactName` char(50) NOT NULL,
  `contactJob` char(50) NOT NULL,
  `officeNo` text NOT NULL,
  `personalNo` text NOT NULL,
  `fax` text,
  `email` text,
  `address` text NOT NULL,
  `city` text NOT NULL,
  `district` text NOT NULL,
  `creditLimit` double NOT NULL,
  PRIMARY KEY (`buyerId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;


>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `available` AS
    SELECT 
        `i`.`ProductID` AS `ProductID`,
        (`i`.`TotalIn` - `o`.`TotalOut`) AS `Total`
    FROM
        (`totalin` `i`
        JOIN `totalout` `o`)
    WHERE
        (`i`.`ProductID` = `o`.`productid`)
		
		>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	
		
		
		CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `totalin` AS
    SELECT 
        `inv_newitems`.`ProductID` AS `ProductID`,
        SUM(`inv_newitems`.`Quantity`) AS `TotalIn`
    FROM
        `inv_newitems`
    GROUP BY `inv_newitems`.`ProductID`
	
	
	
	>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	
	
	
	CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `totalout` AS
    SELECT 
        `inv_inventoryout`.`productid` AS `productid`,
        SUM(`inv_inventoryout`.`quantity`) AS `TotalOut`
    FROM
        `inv_inventoryout`
    GROUP BY `inv_inventoryout`.`productid`
	
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>	
	
	CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `workorderreport` AS
    SELECT 
        `ip`.`productReqId` AS `ProductRequestID`,
        `ip`.`productId` AS `ProductID`,
        `ip`.`quantity` AS `Quantity`,
        `ip`.`requestDate` AS `RequestDate`,
        `ip`.`orderDate` AS `OrderDate`,
        `ip`.`status` AS `Status`,
        `ip`.`notes` AS `Notes`,
        `in`.`ProductName` AS `ProductName`
    FROM
        (`inv_productreq` `ip`
        JOIN `inv_newitems` `in`)
    WHERE
        (`ip`.`productId` = `in`.`ProductID`)
