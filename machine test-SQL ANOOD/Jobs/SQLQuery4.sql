

---- Write an SQL query to retrieve all columns from the employees table where the salary is greater than 50000


SELECT * FROM EMPLOYEES WHERE SALARY >50000;


-----Write a query to display the total number of employees in each department.

SELECT D.DEP_NAME AS DEPARTMENT_NAME ,COUNT(E.EMP_ID) AS TOTAL_EMPLOYEES
FROM DEPARTMENT D 
LEFT JOIN EMPLOYEES E ON D.DEP_ID =E.EMP_DEP 
GROUP BY D.DEP_NAME;


-----Display departments having more than 5 employees.



SELECT D.DEP_NAME AS DEPARTMENT_NAME ,COUNT(E.EMP_ID) AS TOTAL_EMPLOYEES
FROM DEPARTMENT D 
 JOIN EMPLOYEES E ON D.DEP_ID =E.EMP_DEP 
GROUP BY D.DEP_NAME
HAVING COUNT(E.EMP_ID)>5;

-------------------------------------------------------------------------------------
 INSERT INTO EMPLOYEES 
(EMP_NAME ,EMP_DEP,SALARY,PHONE,LOCATION)
VALUES
('Nandhu',3,34000,'2345678900','TCR'),
('Arya',3,36000,'2345678900','TCR');

select * from Employees 


 INSERT INTO EMPLOYEES 
(EMP_NAME ,SALARY,PHONE,LOCATION)
VALUES
('Ganga',34000,'2345678900','TCR');
 


