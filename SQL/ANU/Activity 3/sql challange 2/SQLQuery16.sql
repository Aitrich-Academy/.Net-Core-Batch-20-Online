
SELECT DISTINCT city
FROM customers
ORDER BY city ASC;

------------------------------------------------

SELECT *
FROM customers
WHERE city IN ('New York', 'Los Angeles')
  AND city NOT IN ('Miami');

  -----------------------------------------

  INSERT INTO Customers ( Name, City, Email) 
VALUES ( 'Eve', 'Boston', 'eve@example.com')

--------------------------------------------------

update Customers set city='San Francisco' where Name ='Alice'

-----------------------------------------

DELETE FROM orders
WHERE amount < 400;
 