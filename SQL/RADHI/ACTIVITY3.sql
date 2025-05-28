create database emp;
create table employee(empid int identity(1,1) primary key,Empname varchar(50),DepartmentId int,  
CONSTRAINT FK_Employee_Department FOREIGN KEY (DepartmentID)
        REFERENCES Department(DepartmentID),salary decimal,Hiredate date);
CREATE TABLE Department (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
select * from employee;
select * from Department;
insert into department values(6,'Finance');
insert into employee(Empname,DepartmentId,salary,Hiredate) values('jamesson',2,80000,'1-25-2008');
SELECT DISTINCT DepartmentName,salary
FROM Department,employee
WHERE DepartmentName LIKE 'S%' OR (Salary > 50000 AND DepartmentName <> 'HR');
update  employee set salary =salary * 1.10 where Departmentid=1;
Delete from employee where Hiredate < '2010-01-01';
select empname from employee WHERE Empname LIKE'%SON%'; 
SELECT 
    e.empid,
    e.Empname,
    e.hiredate,
    d.departmentName
FROM 
    employee e
JOIN 
    department d ON e.DepartmentId = d.DepartmentID
WHERE 
    e.hiredate BETWEEN '2015-01-01' AND '2020-12-31';

   

   SELECT 
    e.empid,
    e.empname,
    d.departmentName
FROM 
    employee e
JOIN 
    department d ON e.DepartmentId = d.departmentid
WHERE 
    d.DepartmentName = 'Sales'

UNION

SELECT 
    e.empid,
    e.Empname,
    d.departmentname
FROM 
    employee e
JOIN 
    department d ON e.departmentid = d.departmentid
WHERE 
    d.Departmentname = 'Marketing';

SELECT 
    count(*) as employ_count
	from
	employee e
	JOIN 
	Department d ON e.DepartmentId=d.DepartmentID
	WHERE
	d.DepartmentName='Finance';


	SELECT 
    e.empid,
    e.empname,
    e.salary
FROM 
    employee e
WHERE 
    e.salary > ALL (
        SELECT 
            e2.salary
        FROM 
            employee e2
        JOIN 
            department d ON e2.departmentid = d.departmentid
        WHERE 
            d.departmentname= 'HR'
    );

	SELECT 
    e.empid,
    e.empname,
    e.salary
FROM 
    employee e
WHERE 
    e.salary > ANY (
        SELECT 
            e2.salary
        FROM 
            employee e2
        JOIN 
            department d ON e2.departmentid = d.departmentid
        WHERE 
            d.departmentname = 'Sales'
    );

