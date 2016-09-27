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
  PRIMARY KEY (`buyerId`),
  UNIQUE KEY `storeName_UNIQUE` (`storeName`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

CREATE TABLE `orders` (
  `orderId` int(11) NOT NULL AUTO_INCREMENT,
  `invoiceNo` varchar(20) NOT NULL,
  `orderDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `buyerId` int(11) NOT NULL,
  `productId` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unitPrice` double NOT NULL,
  `total` double NOT NULL,
  `shippingDate` date NOT NULL,
  `empId` int(11) DEFAULT NULL,
  `status` varchar(45) DEFAULT 'Pending',
  PRIMARY KEY (`orderId`),
  UNIQUE KEY `fk_invoiceNum` (`productId`,`invoiceNo`),
  KEY `productId_idx` (`productId`),
  KEY `fk_buyerId_idx` (`buyerId`),
  KEY `fk_employeeId_idx` (`empId`),
  CONSTRAINT `fk_buyerId` FOREIGN KEY (`buyerId`) REFERENCES `buyer` (`buyerId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  constraint `fk_emp` foreign key (`empId`) references `employee` (`EmpId`) ON DELETE NO ACTION ON UPDATE NO ACTION
  CONSTRAINT `fk_productId` FOREIGN KEY (`productId`) REFERENCES `product` (`productId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

CREATE TABLE `payment` (
  `paymentId` int(11) NOT NULL AUTO_INCREMENT,
  `invoiceNo` varchar(20) NOT NULL,
  `paid` double NOT NULL,
  `description` varchar(100) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`paymentId`),
  KEY `fk_invoiceNum_idx` (`invoiceNo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `due` AS select `i`.`invoiceNo` AS `invoiceNo`,`i`.`netTotal` AS `netTotal`,sum(`p`.`paid`) AS `totalPaid` from (`payment` `p` join `invoice` `i`) where (`p`.`invoiceNo` = `i`.`invoiceNo`) group by `p`.`invoiceNo`;


CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `invoice` AS select `o`.`invoiceNo` AS `invoiceNo`,`o`.`orderDate` AS `orderDate`,`o`.`shippingDate` AS `shippingDate`,`o`.`buyerId` AS `buyerId`,`b`.`storeName` AS `storeName`,`o`.`empId` AS `empId`,sum(`o`.`total`) AS `netTotal` from (`orders` `o` join `buyer` `b`) where (`b`.`buyerId` = `o`.`buyerId`) group by `o`.`invoiceNo`;


CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `proddetails` AS select `o`.`orderId` AS `orderId`,`o`.`invoiceNo` AS `invoiceNo`,`o`.`productId` AS `productId`,`i`.`ProductName` AS `productName`,`o`.`quantity` AS `quantity`,`o`.`unitPrice` AS `unitPrice`,`o`.`total` AS `total` from (`orders` `o` join `inv_newitems` `i`) where (`o`.`productId` = `i`.`ProductID`);


//Insert

/*
-- Query: SELECT * FROM itp.buyer
LIMIT 0, 1000

-- Date: 2016-09-24 07:34
*/
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (1,'Wimal Traders','Senanayakke W.','Owner','112342526','719893472','11234526','wimaltraders@gmail.com','20, Galpotha Mw','Kotahena','Colombo',25000);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (2,'Ameer Grocery Stores','Shahib M.A.','Owner','766523974','766523974','0113829421','mameershahib@gmail.com','138A, Galle Road','Dehiwala','Colombo',15000);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (3,'SHIPA Market','Ashif M.','Cashier','778582995','778582995','0112502018','','15, Vihara  Lane','Katugastota','Kandy',20000);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (5,'ABC Imports','Guy','Owner','0112502029','0777377183','0112502029','','15, 5th Cross Street','Colombo 11','Colombo',20000);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (6,'Future World','PersonOne','Owner','0112360245','0777377183','','veivesh95@gmail.com','15, 42nd Lane, Wellawatte, Colombo 06','Colombo','Colombo',12000);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (8,'PNP Super Market','Buddy','Owner','1234567890','1234567890','','','73, test lane, Colombo','Colombo 03','Colombo',15000);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (9,'Super Grocery','PersonTwo','Owner','0112502018','0777377183','','','32, test2 lane, Colombo','Wellwatte','Colombo',10000);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (10,'Grand Traders ','PersonThree','Owner','0112392849','0753282391',NULL,NULL,'9783, Galle Road, Colombo','Colombo 02','Colombo',0);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (11,'Golden Importers','PersonFour','Cashier','0114823924','0712312413',NULL,'test@abc.com','21, Mahabodhi Mw','Colombo 02','Colombo',0);
INSERT INTO `buyer` (`buyerId`,`storeName`,`contactName`,`contactJob`,`officeNo`,`personalNo`,`fax`,`email`,`address`,`city`,`district`,`creditLimit`) VALUES (12,'IO Traders','Aaquiff','Owner','0112930492','0777428382',NULL,'aaquiff@gmail.com','324, School Lane','Colombo 10','Colombo',20000);


/*
-- Query: SELECT * FROM itp.orders
LIMIT 0, 1000

-- Date: 2016-09-24 07:35
*/
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (1,'IN001','2016-08-17 22:55:26',1,1,10,30,300,'2016-08-29',1,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (2,'IN001','2016-08-17 22:55:26',1,2,20,35,700,'2016-08-29',1,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (3,'IN002','2016-08-24 01:23:08',3,3,200,120,24000,'2016-08-26',3,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (4,'IN002','2016-08-24 01:23:09',3,5,100,35,3500,'2016-08-26',3,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (7,'IN003','2016-08-24 01:26:50',5,6,1000,40,40000,'2016-08-31',4,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (8,'IN003','2016-08-24 01:26:50',5,1,2000,30,60000,'2016-08-31',4,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (9,'IN003','2016-08-24 01:27:29',5,2,1000,35,35000,'2016-08-26',4,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (10,'IN003','2016-08-24 01:27:29',5,4,2000,45,90000,'2016-08-26',4,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (11,'IN004','2016-08-24 01:29:26',6,6,1000,40,40000,'2016-08-28',1,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (12,'IN004','2016-08-24 01:29:26',6,3,200,120,24000,'2016-08-28',1,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (14,'IN005','2016-08-24 01:31:17',1,4,1000,45,45000,'2016-08-27',2,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (16,'IN005','2016-08-24 02:35:17',3,3,300,120,36000,'2016-08-31',2,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (17,'IN006','2016-08-24 02:40:06',5,6,200,40,8000,'2016-08-31',3,'Pending');
INSERT INTO `orders` (`orderId`,`invoiceNo`,`orderDate`,`buyerId`,`productId`,`quantity`,`unitPrice`,`total`,`shippingDate`,`empId`,`status`) VALUES (18,'IN006','2016-08-24 02:40:07',5,2,1000,35,35000,'2016-08-31',3,'Pending');


/*
-- Query: SELECT * FROM itp.payment
LIMIT 0, 1000

-- Date: 2016-09-24 07:35
*/
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (1,'IN001',200,'Payee B. Wickram has used Cash Payment method','2016-08-02 00:00:00');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (2,'IN001',400,'Payee B. Wickram has used Cheque Payment method - Cheque No: 5792 / Bank: Sampath','2016-08-10 00:00:00');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (3,'IN001',400,'Payee B. Wickram has used Cash Payment method','2016-08-12 00:00:00');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (4,'IN002',2000,'Payee Ice Bear has used Cash Payment method','2016-08-24 22:47:43');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (6,'IN003',100000,'Payee Quiff has used Cheque Payment method - Cheque No: 2345 / Bank: Sampath','2016-08-25 02:46:33');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (7,'IN003',100000,'Payee Quiff has used Cheque Payment method - Cheque No: 4723 / Bank: Sampath','2016-08-27 02:46:33');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (8,'IN003',25000,'Payee Quiff has used Cash Payment method','2016-08-28 00:00:00');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (9,'IN005',81000,'Payee Sajan has used Cheque Payment method - Cheque No: 9283 / Bank: Commercial','2016-08-30 00:00:00');
INSERT INTO `payment` (`paymentId`,`invoiceNo`,`paid`,`description`,`date`) VALUES (10,'IN004',50000,'Payee Avenash has used Cash Payment method','2016-08-30 00:00:00');

