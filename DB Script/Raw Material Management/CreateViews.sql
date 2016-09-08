DROP VIEW IF EXISTS `raw_purchase_order` ;
DROP VIEW IF EXISTS `raw_order_line` ;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_order_line` AS
 (select 
 `raw_order_line_tab`.`order_id` AS `order_id`,
 `raw_order_line_tab`.`item_id` AS `item_id`,
 `raw_order_line_tab`.`unit_price` AS `unit_price`,
 `raw_order_line_tab`.`quantity` AS `quantity`,
 `raw_item_tab`.`name` AS `item_name`,
 `raw_item_tab`.`unit_of_measure` AS `unit_of_measure`,
 (`raw_order_line_tab`.`quantity` * `raw_order_line_tab`.`unit_price`) AS `amount` 
 from (`raw_order_line_tab` left join `raw_item_tab` on((`raw_order_line_tab`.`item_id` = `raw_item_tab`.`item_id`))));


CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `raw_purchase_order` 
AS (
select 
`raw_purchase_order_tab`.`order_id` AS `order_id`,
`raw_purchase_order_tab`.`creation_date` AS `creation_date`,
`raw_purchase_order_tab`.`creator` AS `creator`,
`raw_purchase_order_tab`.`status` AS `status`,
`raw_purchase_order_tab`.`approver` AS `approver`,
`raw_purchase_order_tab`.`shipping_address` AS `shipping_address`,
`raw_purchase_order_tab`.`supplier_id` AS `supplier_id`,
`raw_purchase_order_tab`.`notes` AS `notes`,
`GET_SUPPLIER_NAME`(`raw_purchase_order_tab`.`supplier_id`) AS `supplier_name`,
sum(`raw_order_line`.`amount`) AS `sub_total`,`raw_purchase_order_tab`.`discount` AS `discount`,
(sum(`raw_order_line`.`amount`) - ((`raw_purchase_order_tab`.`discount` / 100) * sum(`raw_order_line`.`amount`))) AS `total` 
from (`raw_purchase_order_tab` left join `raw_order_line` on((`raw_purchase_order_tab`.`order_id` = `raw_order_line`.`order_id`))) group by `raw_purchase_order_tab`.`order_id`);


