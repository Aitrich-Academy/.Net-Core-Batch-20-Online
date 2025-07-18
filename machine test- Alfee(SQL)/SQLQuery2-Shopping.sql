create database Shopping

create table Customers(CustomerId int PRIMARY KEY, CustomerName varchar(100),City varchar(100));

insert into Customers values(1,'Alice', 'New York'),
                            (2,'Bob', 'Chicago'),
							(3,'Charlie', 'Los Angeles'),
							(4,'David', 'Houston');
select * from Customers;

create table Orders(OrderId int PRIMARY KEY, CustomerId int, OrderDate date, TotalAmount int, Foreign key(CustomerId) references Customers(CustomerId));

insert into Orders values(101, 1, '2024-02-15', 500),
                         (102, 2, '2024-02-16', 700),
						 (103, 1, '2024-03-01', 200),
						 (104, 3, '2024-03-05', 900),
						 (105, 2, '2024-03-07', 450);
select * from Orders;

select 
       Customers.CustomerName,
       Sum(Orders.TotalAmount)As TotalSpent
From Customers
Join Orders on Customers.CustomerId = Orders.CustomerId
Group by Customers.CustomerName;

select
       Customers.CustomerId,
	   Customers.CustomerName
From Customers
Left join Orders on Customers.CustomerId = Orders.CustomerId
where Orders.CustomerId is null;

select 
      CustomerId,
	  Max(OrderDate) As MostRecentOrder
From Orders
Group by CustomerId;

select Top 1
      Customers.CustomerName,
	  Sum (Orders.TotalAmount) As TotalSpent
From Customers
Join Orders on Customers.CustomerId = Orders.CustomerId
Group by Customers.CustomerName
Order by TotalSpent Desc;

select
      Count(*) As TotalOrersInMarch
From Orders
Where OrderDate>='2024-03-01' and OrderDate<='2024-03-31';