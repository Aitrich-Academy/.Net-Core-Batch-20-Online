create database Job;
create table Employee( id int PRIMARY KEY, Name varchar(100), Gender varchar(2), Designation varchar(50), Salary int, City varchar(50));
create table 

insert into Employee values(1, 'Alfee', 'Female', 'Developer', '20000', 'Perumbavoor');
insert into Employee values(2, 'Anzal', 'Male', 'Football Player', '30000', 'Aluva');
insert into Employee values(3, 'Anupama', 'Female', 'Teacher', '25000', 'Muvattupuzha');
insert into Employee values(4, 'Sreejith', 'Male', 'Mechanic', '26000', 'Kothamangalam');
insert into Employee values(5, 'Bibinsha', 'Female', 'Developer', '20000', 'Perumbavoor');

select * from Employee;
select Name from Employee;

select COUNT(*) from Employee;
select COUNT(Name) from Employee;
select COUNT(1) from Employee;

select COUNT(1) as Count_of_Employee from Employee;
select COUNT(Designation) from Employee;

select Sum(Salary)as Total_Salary from Employee;
select Name,Sum(Salary)as Total_Salary from Employee group by Name;

select Max(Salary)as Maximum_Salary from Employee
select Name,Max(Salary)as Maximum_Salary from Employee group by Name;

select City,Sum(Salary)as Total_Salary from Employee group by City;
select City, Designation ,Sum(Salary)as Total_Salary from Employee group by City,Designation;
select City, Designation ,Sum(Salary)as Total_Salary from Employee group by City,Designation order by City desc;

select City,Sum(Salary)as Total_Salary from Employee group by City having Sum(Salary)>20000;



