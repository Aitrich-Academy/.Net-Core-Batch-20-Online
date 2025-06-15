create database emp;
create table 
employee(id int identity(1,1) primary key,Name varchar(50),Gender Varchar(50),Designation varchar(50),Salary int,City varchar(50));
insert into employee(Name,Gender,Designation,Salary,city)values('Reshma','F','SE',320000,'cochi');
select * from employee;
select name from employee;
select count (name) from employee;
select count(1) as count_of_employee from employee;
select count(1) from employee;
select sum(Salary) from employee;
select sum(Salary),name as total from employee group by ;
select MAX(SALARY)as maximum from employee; 
select Name, MAX(SALARY)as Maximum_Salary from employee Group by Name; 
SELECT city,SUM(SALARY)as total_salary from employee group by city;
select city,designation,Sum(Salary) As total_salary from employee group by Designation,city;
select city,designation,Sum(Salary) As total_salary from employee group by Designation,city order by city desc;
select city,SUM(Salary)as total_salary from employee group by city having sum(salary)>50000;