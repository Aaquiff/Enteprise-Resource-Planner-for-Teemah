CREATE TABLE `inv_newitems` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ReceivedDate` varchar(30) DEFAULT NULL,
  `BatchNo` int(11) DEFAULT NULL,
  `ManufacturedDate` varchar(30) DEFAULT NULL,
  `ExpiredDate` varchar(30) DEFAULT NULL,
  `ProductID` varchar(20) DEFAULT NULL,
  `ProductName` varchar(50) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `PPUnit` double DEFAULT NULL,
  `Packed` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=671 DEFAULT CHARSET=utf8;



 
CREATE TABLE `inv_order` (
  `orderid` int(11) NOT NULL AUTO_INCREMENT,
  `orderdate` varchar(45) DEFAULT NULL,
  `deliverydate` varchar(45) DEFAULT NULL,
  `productid` int(11) DEFAULT NULL,
  `productname` varchar(45) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `maximumretailprice` int(11) DEFAULT NULL,
  `unitprice` int(11) DEFAULT NULL,
  PRIMARY KEY (`orderid`)
) ENGINE=InnoDB AUTO_INCREMENT=23212 DEFAULT CHARSET=utf8;


CREATE TABLE `inv_productreq` (
  `productReqId` int(11) NOT NULL AUTO_INCREMENT,
  `productId` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `requestDate` date DEFAULT NULL,
  `orderDate` date DEFAULT NULL,
  `status` varchar(32) DEFAULT 'pending',
  `notes` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`productReqId`),
  KEY `productId_idx` (`productId`),
  CONSTRAINT `productId` FOREIGN KEY (`productId`) REFERENCES `products` (`productId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2324 DEFAULT CHARSET=utf8;



 
CREATE TABLE `products` (
  `productId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  `notes` varchar(256) DEFAULT NULL,
  `weight` int(11) DEFAULT NULL,
  PRIMARY KEY (`productId`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
