Select * from Users where Role='Jobseeker'


Select * from Users where Role='Jobseeker' and Email='yadhu.aitrich@gmail.com'


----Show all job providers FirstName,LastName,Email, Phone, Company Name
  	
	SELECT 
	u.FirstName,
	u.LastName, 
	u.Email, 
	u.Phone, 
	c.Name FROM
	users u
INNER JOIN
companies c 
ON 
u.CompanyId = c.Id
