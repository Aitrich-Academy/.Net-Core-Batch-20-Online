CREATE DATABASE ShopDB;

CREATE TABLE customer 
(
  cid INT IDENTITY(1,1) PRIMARY KEY,
  customername VARCHAR(50)
);


 INSERT INTO customer (customername) VALUES ('Anu');
INSERT INTO customer (customername) VALUES ('Radhi');
INSERT INTO customer (customername) VALUES ('Nasif');
INSERT INTO customer (customername) VALUES ('Vidhya');
INSERT INTO customer (customername) VALUES ('Alice');
INSERT INTO customer (customername) VALUES ('Bob');
INSERT INTO customer (customername) VALUES ('kevin');
INSERT INTO customer (customername) VALUES ('Rasin'); 

select * from customer




