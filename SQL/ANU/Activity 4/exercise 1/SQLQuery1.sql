CREATE DATABASE University_System

-----TABLE-UNIVERSITY

CREATE TABLE University (
    UID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(20),
    Chancellor VARCHAR(20)
);

 -----Table - College

 CREATE TABLE College (
    CID INT IDENTITY(1,1) PRIMARY KEY,
    University INT,
    Dean INT,
    CName VARCHAR(20),
    FOREIGN KEY (University) REFERENCES University(UID),
    FOREIGN KEY (Dean) REFERENCES Dean(DeanID)
);

--Table - Dean

CREATE TABLE Dean (
    DeanID INT identity(1,1) PRIMARY KEY,
    DeanName VARCHAR(20),
    DateOfBirth DATETIME
);



--Table - Department


CREATE TABLE Department (
    DepID INT identity(1,1) PRIMARY KEY,
    College INT,
    DepName VARCHAR(20),
    FOREIGN KEY (College) REFERENCES College(CID)
);

