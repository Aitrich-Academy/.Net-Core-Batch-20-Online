create database Shop;
create table Customers (CustomerID int PRIMARY KEY, CustomerName varchar(100),City varchar(50));
create table Orders (OrderID int PRIMARY KEY, CustomerID int,OrderDate date, FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID));
create table OrderDetails (OrderDetailID int PRIMARY KEY,OrderID int,ProductID int,Quantity int,FOREIGN KEY (OrderID) REFERENCES Orders(OrderID));
create table Employees (EmployeeID int PRIMARY KEY,EmployeeName varchar(100),Department varchar(50));

insert into Customers values(1,'Alfee','Dubai');
insert into Customers values(2,'Ajmal','Diera');
insert into Customers values(3,'Anzal','Gardens');
insert into Customers values(4,'Anood','Diera');
insert into Customers values(5,'Radhi','Diera');
insert into Customers values(6,'Remya','Diera');


insert into Orders values (101, 1, '2025-01-10');
insert into Orders values(102, 1, '2025-02-15');
insert into Orders values (103, 2, '2025-03-20');
insert into Orders values (104, 1, '2025-04-01');
insert into Orders values (105, 3, '2025-04-10');
insert into Orders values (106, 1, '2025-05-05');
insert into Orders values (107, 1, '2025-05-06');

insert into OrderDetails values (1, 101, 10, 2);
insert into OrderDetails values (1, 101, 10, 2);
insert into OrderDetails values (2, 102, 20, 1);
insert into OrderDetails values (3, 103, 10, 5);
insert into OrderDetails values (4, 104, 30, 2);
insert into OrderDetails values (5, 105, 10, 3);
insert into OrderDetails values(6, 106, 20, 4);

insert into Employees values (1, 'Anna', 'HR');
insert into Employees values (2, 'Bincy', 'IT');
insert into Employees values (3, 'Arun', 'IT');
insert into Employees values (4, 'Akash', 'Finance');
insert into Employees values (5, 'Emily', 'HR');

select * from Customers;
select * from Orders;


select CustomerID, count(OrderID) as OrderCount
from Orders
group by CustomerID;

select CustomerID, count(OrderID) as OrderCount
from Orders
group by CustomerID
having count(OrderID) > 4;

select ProductID, count(*) as Occurrence
from OrderDetails
group by ProductID
having count(*) > 1;

select Department, count(*) as EmployeeCount
from Employees
group by Department;

select City, count(*) as CustomerCount
from Customers
group by City
having count(*) > 3;



    