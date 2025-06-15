INSERT INTO Customers ( Name, City, Email) 
VALUES ( 'Alice', 'New York', 'alice@example.com'), 
( 'Bob', 'Los Angeles', 'bob@example.com'), 
( 'Charlie', 'Chicago', 'charlie@example.com'), 
( 'David', 'Miami', NULL); 

 INSERT INTO Orders ( CustomerID, OrderDate, Amount) 
 VALUES 
 ( 1, '2023-10-01', 500.00), ( 2, '2023-10-05', 300.00), 
 ( 1, '2023-10-10', 700.00), ( 3, '2023-10-12', 450.00), ( 2, '2023-11-01', 200.00);


 select * from Customers 
select * from Orders 