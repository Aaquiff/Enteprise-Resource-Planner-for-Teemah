drop view if exists `user`;
drop view if exists `user_role`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user` AS 
select `ut`.`user` AS `user`,
`ut`.`name` AS `name`,
`mu`.`Password` AS `password`
 from (`user_tab` `ut` left join `mysql`.`user` `mu` on((convert(`ut`.`user` using utf8) = `mu`.`User`)));

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `user_role` AS 
select `user_role_tab`.`user` AS `user`,
`user_role_tab`.`role` AS `role`,
`role_tab`.`description` AS `description`
from (`user_role_tab` join `role_tab` on((`user_role_tab`.`role` = `role_tab`.`role`)));
