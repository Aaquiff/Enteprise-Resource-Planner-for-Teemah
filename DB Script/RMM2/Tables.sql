CREATE TABLE `raw_supplier_tab` (
  `supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(500) NOT NULL,
  `contact_person` varchar(200) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `address` varchar(500) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`),
  UNIQUE KEY `name` (`name`),
  UNIQUE KEY `phone` (`phone`),
  UNIQUE KEY `address` (`address`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=latin1;

CREATE TABLE `raw_item_tab` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(2000) NOT NULL,
  `description` varchar(2000) DEFAULT NULL,
  `stock_level` int(11) DEFAULT '0',
  `unit_of_measure` varchar(20) NOT NULL,
  `item_category` varchar(200) DEFAULT NULL,
  `bar_code` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1020 DEFAULT CHARSET=latin1;

CREATE TABLE `raw_settings_tab` (
  `setting` varchar(20) DEFAULT NULL,
  `value` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_purchase_order_tab` (
  `order_id` varchar(200) NOT NULL,
  `creation_date` date NOT NULL,
  `creator` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `approver` varchar(200) NOT NULL,
  `shipping_address` varchar(500) NOT NULL,
  `supplier_id` varchar(200) NOT NULL,
  `notes` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_order_line_tab` (
  `order_id` varchar(200) NOT NULL,
  `item_id` int(11) NOT NULL,
  `unit_price` double NOT NULL,
  `quantity` double NOT NULL,
  PRIMARY KEY (`order_id`,`item_id`),
  KEY `fkItemId_idx` (`item_id`),
  CONSTRAINT `fk_order_line_item` FOREIGN KEY (`item_id`) REFERENCES `raw_item_tab` (`item_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_invoice_tab` (
  `invoice_id` varchar(200) NOT NULL,
  `order_id` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `date` date NOT NULL,
  `due_date` date NOT NULL,
  `original_due_date` date NOT NULL,
  `net_value` double NOT NULL,
  `tax_value` double NOT NULL,
  `gross_value` double NOT NULL,
  `discount` int(11) NOT NULL,
  `currency` varchar(200) NOT NULL,
  PRIMARY KEY (`invoice_id`),
  KEY `fkInvoiceOrder_idx` (`order_id`),
  CONSTRAINT `fkInvoiceOrder` FOREIGN KEY (`order_id`) REFERENCES `raw_purchase_order_tab` (`order_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `raw_currency_tab` (
  `currency` varchar(20) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`currency`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `empId` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`orderId`),
  UNIQUE KEY `fk_invoiceNum` (`productId`,`invoiceNo`),
  KEY `productId_idx` (`productId`),
  KEY `fk_buyerId_idx` (`buyerId`),
  KEY `fk_employeeId_idx` (`empId`),
  CONSTRAINT `fk_buyerId` FOREIGN KEY (`buyerId`) REFERENCES `buyer` (`buyerId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_employeeId` FOREIGN KEY (`empId`) REFERENCES `employee` (`EmpId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

