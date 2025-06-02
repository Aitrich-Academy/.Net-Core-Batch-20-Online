
SELECT COUNT(*) AS total_customers
FROM customers;

---------------------------------------


SELECT *
FROM customers
WHERE name LIKE 'A%';

--------------------------------------------


SELECT *
FROM Orders 
WHERE  OrderDate BETWEEN '2023-10-01' AND '2023-10-10';


-------------------------------------------------------

SELECT
    c.Name,
    o.Amount
FROM
    Customers c
JOIN
    Orders o ON c.CustomerID = o.CustomerID;

	----------------------------------------------------------------