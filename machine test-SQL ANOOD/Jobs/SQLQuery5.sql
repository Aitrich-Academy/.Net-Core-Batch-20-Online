
---Retrieve the top 5 highest-paid employees.

SELECT TOP 5 *  FROM EMPLOYEES 
ORDER BY SALARY DESC ;


------list all employees and their departments, including those without any department.

SELECT *,D.DEP_NAME AS DEPARTMENT_NAME FROM EMPLOYEES E
LEFT JOIN DEPARTMENT D ON
E.EMP_DEP =D.DEP_ID 


----Find employees whose salary is greater than the average salary.

SELECT * FROM EMPLOYEES 
WHERE SALARY  > (SELECT AVG(SALARY) FROM EMPLOYEES );



---SELECT AVG(SALARY) FROM EMPLOYEES;

 





