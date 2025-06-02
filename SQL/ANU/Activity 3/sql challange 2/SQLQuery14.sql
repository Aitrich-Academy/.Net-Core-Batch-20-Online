create database customer_order_relation


CREATE TABLE Customers (
    CustomerID INT identity(1,1) PRIMARY KEY,
    Name VARCHAR(50),
    City VARCHAR(50),
    Email VARCHAR(50)
);




CREATE TABLE Orders (
    OrderID INT identity(1,1) PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    Amount DECIMAL(10,2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);



