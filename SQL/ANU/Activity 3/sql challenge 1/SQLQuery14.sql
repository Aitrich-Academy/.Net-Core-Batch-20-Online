
-----Check if any employees exist in the 'Finance' department.

SELECT *
FROM Employee e
JOIN Department d ON e.DepartmentID = d.DepartmentID
WHERE d.DepartmentName = 'Finance';

---------------------------------------------------------------------


IF EXISTS (
    SELECT 1
    FROM Employee e
    JOIN Department d ON e.DepartmentID = d.DepartmentID
    WHERE d.DepartmentName = 'Finance'
)
BEGIN
    PRINT 'Employees exist in the Finance department.';
END
ELSE
BEGIN
    PRINT 'No employees in the Finance department.';
END
