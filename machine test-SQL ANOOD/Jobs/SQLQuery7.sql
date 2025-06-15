

-----Write a query to update the salary of employees in 'HR' department by 10%.

UPDATE EMPLOYEES 
SET 
SALARY = SALARY * 1.10
 WHERE 
 EMP_DEP =
 (SELECT DEP_ID FROM DEPARTMENT WHERE DEP_NAME='HR');

-----------------------------------------------------------------
 SELECT * FROM EMPLOYEES 
 SELECT * FROM EMPLOYEES WHERE EMP_DEP =1;

 -------------------------------------------------------




 
