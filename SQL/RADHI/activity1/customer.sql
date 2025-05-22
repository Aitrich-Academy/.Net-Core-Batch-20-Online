create database shops;
create table customer(cid INT Identity(1,1) primary key,customername varchar(50));
select * from customer;
CREATE TABLE orders(orderid INT IDENTITY (1,1)PRIMARY KEY,
	cid INT,orderdate DATE,FOREIGN KEY(cid) references customer(cid));
	alter table product add constraint productid foreign key (productid) references orders; 
	select * from orders;
	create table product(productid int identity(1,1) primary key,productName varchar(50));
	select * from product;
	insert into product (productname) values ('bag');
	insert into product (productname) values ('umbrella');
	insert into product (productname) values ('book');
	insert into customer (customername) values ('alice');
		insert into customer (customername) values ('Bob');
			insert into customer (customername) values ('kevin');
				insert into customer (customername) values ('Rasin');
				INSERT INTO orders (cid, orderdate) VALUES (1, '2023-01-01');
INSERT INTO orders (cid, orderdate) VALUES (2, '2023-01-03');
INSERT INTO orders (cid, orderdate) VALUES (2, '2023-01-03');
INSERT INTO orders (cid, orderdate) VALUES (2, '2023-03-03');
INSERT INTO orders (cid, orderdate) VALUES (2, '2023-05-03');
INSERT INTO orders (cid, orderdate) VALUES (2, '2023-01-04');
INSERT INTO orders (cid, orderdate,productid) VALUES (1, '2024-03-04',2);

SELECT cid,count(*) as ordercount from orders group by cid;
SELECT c.customername, COUNT(*) AS OrderCount
FROM orders o
JOIN customer c ON o.cid = c.cid
GROUP BY c.customername;
select cid, count(orderid) As Totalorders from orders group by cid Having count(orderid)>5;
 alter table orders add productid int;

 select productid,count(*) As count from orders group by productid having count(*)>1;