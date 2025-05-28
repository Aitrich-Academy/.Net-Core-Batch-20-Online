create database customers;
CREATE TABLE Customers (
CustomerID INT PRIMARY KEY,
Name VARCHAR(50),
City VARCHAR(50),
Email VARCHAR(50)
);
CREATE TABLE Orders (
OrderID INT PRIMARY KEY,
CustomerID INT,
OrderDate DATE,
Amount DECIMAL(10,2),
FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Customers (CustomerID, Name, City, Email) VALUES (1,'Alice','NewYork','alice@example.com'),
(2,'Bob','Los Angeles','bob@example.com'),
(3,'Charlie','Chicago','charlie@example.com'),
(4,'David','Miami', NULL);
-- Orders Table Data
INSERT INTO Orders (OrderID, CustomerID, OrderDate, Amount) VALUES 
(101,1,'2023-10-01', 500.00), (102, 2,'2023-10-05', 300.00),
(103, 1, '2023-10-10', 700.00), (104, 3, '2023-10-12', 450.00), (105, 2,'2023-11-01', 200.00);
select * from orders;
select * from customers;
select distinct city from customers;
select *  from customers where city='New York' or city='Los Angeles' ;
SELECT *
FROM Customers
WHERE City IN ('New York', 'Los Angeles')and city!='miami';


Update customers set city= 'sanfranciscco' where name='bob';
delete   from Orders where Amount<400;
select count(*) from customers;
select name from customers where name like 'a%';
select * from orders where OrderDate  between'2023-10-01'AND '2023-10-12';
SELECT Customers.Name, Orders.Amount
FROM Customers
JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
SELECT DISTINCT Customers.City
FROM Customers
JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
select city, count(*) as number_of_customer from customers group by City ;
SELECT City,count(*) as customer from customers group by City having count(*)>1;
SELECT DISTINCT Customers.*
FROM Customers
JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
select customers.* from customers  join orders on Customers.CustomerID=Orders.CustomerID where orders.Amount>500;
select * from Customers where Email is null;
SELECT City, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY City
ORDER BY CustomerCount DESC;

SELECT *
INTO Customers_Backup
FROM Customers;
CREATE TABLE Customers_Backup (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50),
    City VARCHAR(50),
    Email VARCHAR(50)
);
INSERT INTO Customers_Backup
SELECT * FROM Customers;
SELECT *
INTO Customers_NewYork
FROM Customers
WHERE City = 'New York';








