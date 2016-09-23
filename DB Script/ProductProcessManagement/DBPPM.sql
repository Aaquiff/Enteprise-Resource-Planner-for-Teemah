Create Table Products(
	productId integer primary key not null auto_increment,
	name varchar(32),
	description varchar(256),
	notes varchar(256),
	-- Weight in grams as default
	weight integer
	-- Initial Estimated Production Time in hours
	-- IEPT integer
);

Create Table Products_RawMaterials(
	productId integer references Products,
    rawMaterialId integer references raw_item_tab(item_id),
    quantity int,
    notes varchar(256),
    constraint primary key(productId,rawMaterialId)
);


Create Table WorkOrders(
	workOrderId integer primary key not null auto_increment,
	productId integer  references Products,
	quantity int,
	-- Status should be enumerable
	status varchar(32),
    state varchar(32),
    notes varchar(256),
	-- Export point can be enumerable and a foreign key
	exportPoint varchar(32),
	startDate date,
	endDate date,
	-- refrence can be null or valued
	reference int references ProductReq
);


Create Table ProductReq(
	productReqId int primary key not null auto_increment,
	productId integer  references Products,
	quantity int,
	requestDate date,
	orderDate date,
	-- Status can be enumberable - approved or rejected
	status varchar(32),
	notes varchar(256)
);


Create Table TransportReq(
	transportReqId int primary key not null auto_increment,
	-- From & to can be enumerable
	trFrom varchar(32),
	trTo varchar(32),
	requestDate date,
	transportDate date,
	status varchar(32),
	notes varchar(256),
	reference int references WorkOrders
);




Create Table RawMatReq(
	rawMatReqId int primary key not null auto_increment,
	-- rawMaterial int foreign key references 
    productId integer  references Products,
	quantity int,
	requestDate date,
	orderDate date,
	status varchar(32),
	notes varchar(256),
	reference int references WorkOrders
);


Create Table Remarks(
	remarkId int primary key not null auto_increment,
	-- Status shoudl be unerbale --solved/need attention
    title varchar(32),
	status varchar(32),
	priority int,
	created date,
	lastAction date,
	notes varchar(256),
	reference int references WorkOrder,
    archived boolean

);


insert into Products(name,description,notes,weight) values('Marie Gold','Gold Marie export Quality Biscuits','Dummy Note 1',90);
insert into Products(name,description,notes,weight) values('Choco Marie','Choco Marie for Local Distributions','Dummy Note 2',90);
insert into Products(name,description,notes,weight) values('Chocolate Chips','Chocolate Chips to distrubute locally','Dummy Note 3',120);
insert into Products(name,description,notes,weight) values('Dark Fantasy','Dark Fantasy export Quality','Dummy Note 4',150);
insert into Products(name,description,notes,weight) values('Cream Crackers','Medium Sized Cream Crackers','Dummy Note 5',200);
insert into Products(name,description,notes,weight) values('Rice Cookies','Export Quality Rice Cookies','Dummy Note 6',120);
insert into Products(name,description,notes,weight) values('Chocolate Cookies','Export Quality Chocolate Cookies','Dummy Note 7',120);
insert into Products(name,description,notes,weight) values('Marie Light','Marie Light for local distribution','Dummy Note 8',90);
insert into Products(name,description,notes,weight) values('Vanila Waffers','Vanila Waffers for local distributions','Dummy Note 9',80);
insert into Products(name,description,notes,weight) values('Chocolate Waffers','Chocolate Waffers for local distributions','Dummy Note 10',80);

insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (1,2,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (1,3,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (1,4,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (2,2,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (2,3,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (2,5,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (3,3,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (3,2,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (3,4,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (4,2,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (4,3,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (4,4,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (5,3,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (5,2,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (5,1,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (6,3,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (6,4,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (6,1,15);
insert into Products_RawMaterials(productId,rawMaterialId,quantity) values (7,2,15);




insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,500,'not started','active','Dummy Notes','Dest1','2016-11-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,300,'not started','active','Dummy Notes','Dest1','2016-10-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,200,'not started','active','Dummy Notes','Dest1','2016-12-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,500,'not started','active','Dummy Notes','Dest1','2016-11-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,300,'not started','active','Dummy Notes','Dest1','2016-12-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,400,'not started','active','Dummy Notes','Dest1','2016-11-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,200,'not started','active','Dummy Notes','Dest1','2016-10-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,400,'not started','active','Dummy Notes','Dest1','2016-09-11',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,600,'not started','active','Dummy Notes','Dest1','2016-09-05',null,null);
insert into WorkOrders(productId,quantity,status,state,notes,exportPoint,startDate,endDate,reference) values(1,600,'not started','active','Dummy Notes','Dest1','2016-09-15',null,null);





insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,500,'2016-08-22','2016-09-22',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,300,'2016-07-22','2016-10-10',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,500,'2016-08-20','2016-09-22',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,600,'2016-08-15','2016-11-22',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,300,'2016-05-20','2016-12-22',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,200,'2016-08-14','2016-10-25',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,500,'2016-07-18','2016-09-22',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,400,'2016-08-16','2016-09-10',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,300,'2016-07-18','2016-10-15',null,null);
insert into ProductReq(productId,quantity,requestDate,orderDate,status,notes) values(1,400,'2016-08-20','2016-09-24',null,null);




insert into TransportReq(trFrom,trTo,requestDate,transportDate,status,notes,reference) values('dest1','dest2','2016-08-28','2016-09-22','not approved',null,null);
insert into TransportReq(trFrom,trTo,requestDate,transportDate,status,notes,reference) values('dest3','dest4','2016-08-24','2016-08-30','not approved',null,null);
insert into TransportReq(trFrom,trTo,requestDate,transportDate,status,notes,reference) values('dest5','dest6','2016-08-30','2016-09-02','not approved',null,null);
insert into TransportReq(trFrom,trTo,requestDate,transportDate,status,notes,reference) values('dest7','dest8','2016-08-29','2016-09-11','not approved',null,null);
insert into TransportReq(trFrom,trTo,requestDate,transportDate,status,notes,reference) values('dest9','dest10','2016-08-26','2016-09-08','not approved',null,null);




insert into RawMatReq(productId,quantity,requestDate,orderDate,status,notes,reference) values(1,400,'2016-08-22','2016-08-28','pending',null,null);
insert into RawMatReq(productId,quantity,requestDate,orderDate,status,notes,reference) values(2,400,'2016-08-21','2016-09-28','pending',null,null);
insert into RawMatReq(productId,quantity,requestDate,orderDate,status,notes,reference) values(3,400,'2016-08-20','2016-09-10','pending',null,null);
insert into RawMatReq(productId,quantity,requestDate,orderDate,status,notes,reference) values(4,600,'2016-08-18','2016-08-29','pending',null,null);
insert into RawMatReq(productId,quantity,requestDate,orderDate,status,notes,reference) values(5,500,'2016-08-15','2016-08-25','pending',null,null);




insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 1','Not Reviewed',5,'2016-08-21','2016-08-22',null,null,false);
insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 2','Not Reviewed',5,'2016-08-21','2016-08-22',null,null,false);
insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 3','Not Reviewed',5,'2016-08-21','2016-08-22',null,null,true);
insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 4','Not Reviewed',5,'2016-08-21','2016-08-22',null,null,true);
insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 5','Not Reviewed',5,'2016-08-21','2016-08-22',null,null,false);
insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 6','Not Reviewed',9,'2016-08-21','2016-08-22',null,1,false);
insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 7','Not Reviewed',10,'2016-08-21','2016-08-22',null,1,false);
insert into Remarks(title,status,priority,created,lastAction,notes,reference,archived) values('Note title 8','Not Reviewed',5,'2016-08-21','2016-08-22',null,1,false);
