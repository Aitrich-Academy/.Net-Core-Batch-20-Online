----Copy all customer data into a backup table.


SELECT * INTO Customers_Backup FROM Customers;

------------------------------------

----	Insert all customers who live in 'New York' into another table.

INSERT INTO TargetTable (CustomerID, Name,  City, Email)
SELECT CustomerID, Name, City,Email 
FROM Customers
WHERE City = 'Boston';


 CREATE TABLE TargetTable (
    CustomerID INT   PRIMARY KEY,
    Name VARCHAR(50),
    City VARCHAR(50),
    Email VARCHAR(50)
);

select * from customers

select * from TargetTable 