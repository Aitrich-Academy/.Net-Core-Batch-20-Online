select * from customers

select * from orders

----	Retrieve all cities from both Customers and Orders tables.

SELECT City FROM Customers
 

 ----Count the number of customers in each city.

 SELECT City, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY City;



insert into customers (name,city,email) values ('mark','Boston','mark@gmail.com')


----	Retrieve cities where the number of customers is greater than 1.
SELECT City, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY City
HAVING COUNT(*) > 1;


----	Retrieve customers who have placed at least one order.

SELECT 
    c.CustomerID,
    c.Name,
    COUNT(o.OrderID) AS NumberOfOrders
FROM 
    Customers c
JOIN 
    Orders o ON c.CustomerID = o.CustomerID
GROUP BY 
    c.CustomerID, c.Name;
	-----------------------------------------------------------------

	select * from customers

	select * from orders