select * from Employee 
-----------------------------------------------
UPDATE Employee
SET salary  = 49000
WHERE id=1;
----------------------------------------------------------

SELECT * 
FROM Employee
WHERE City = 'Delhi';
-------------------------------------------------------

insert into Employee 
(name,gender,designation ,salary ,city,department_id )
values('Rohan',
'M','Developer',86000,'Palakkad',1)