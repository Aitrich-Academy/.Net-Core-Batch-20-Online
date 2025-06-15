-----	Retrieve customers who have orders with amounts greater than 500.

SELECT DISTINCT c.CustomerID, c.Name
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.Amount > 500;


select * from orders

---	Retrieve customers without an email

SELECT CustomerID, Name
FROM Customers
WHERE Email IS NULL OR Email = '';

--------------------------------------------
-----Categorize customers based on their city.

SELECT City, COUNT(*) AS CustomerCount
FROM Customers
GROUP BY City
ORDER BY CustomerCount DESC;