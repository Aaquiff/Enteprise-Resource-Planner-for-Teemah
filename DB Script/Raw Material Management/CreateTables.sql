DROP TABLE IF EXISTS  `raw_invoice_tab`;
DROP TABLE IF EXISTS  `raw_order_line_tab`;
DROP TABLE IF EXISTS  `raw_purchase_order_tab`;
DROP TABLE IF EXISTS  `raw_supplier_tab`;
DROP TABLE IF EXISTS  `raw_item_tab`;


CREATE TABLE `raw_item_tab` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(2000) NOT NULL,
  `description` varchar(2000) DEFAULT NULL,
  `stock_level` int(11) DEFAULT '0',
  `unit_of_measure` varchar(20) NOT NULL,
  `item_category` varchar(200) DEFAULT NULL,
  `bar_code` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) 
ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

CREATE TABLE `raw_supplier_tab` (
  `supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(500) UNIQUE NOT NULL,
  `contact_person` varchar(200) DEFAULT NULL,
  `phone` varchar(20) UNIQUE DEFAULT NULL,
  `address` varchar(500) UNIQUE DEFAULT NULL,
  `email` varchar(100) UNIQUE DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

CREATE TABLE `raw_purchase_order_tab` (
  `order_id` varchar(200) NOT NULL,
  `creation_date` date NOT NULL,
  `creator` varchar(200) NOT NULL,
  `status` varchar(200) NOT NULL,
  `approver` varchar(200) NOT NULL,
  `shipping_address` varchar(500) NOT NULL,
  `supplier_id` varchar(200) NOT NULL,
  `discount` double DEFAULT NULL,
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