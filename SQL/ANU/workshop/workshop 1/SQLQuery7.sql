
select * from users 


UPDATE Users SET  
Phone = '8085499250', 
Location='Kochi',
About='Experienced .NET developer with 5+ years of experience in building Enterprise applications' 
WHERE email = 'yadhu.aitrich@gmail.com';
----------------------------------------------------------



ALTER TABLE users ALTER COLUMN About varchar(100);
-------------------------------------------------------------------



UPDATE Users SET 
CompanyId= 'ab5f391e-d83e-4eae-87cd-bca23175cf22'
WHERE email = 'soudha.aitrich@gmail.com';
