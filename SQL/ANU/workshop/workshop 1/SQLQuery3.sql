

 INSERT INTO Companies
 ( Id,Name, Email, Website, Phone, Logo,About, Vision, Mission, Location, Address, Status)      
VALUES 
(
'ab5f391e-d83e-4eae-87cd-bca23175cf22',
'Aitrich Academy ',
'aitrich.academy@aitrich.com',
'https://aitrichacademy.com/', 
'0487012312',
NULL,
'About us ',
' Our Vision ',
'Our Mission', 
'thrissur',
'',
'A')

select * from companies



UPDATE Companies SET 
Name = 'Aitrich Academy',
Address='Aitrich Academy , Thrissur'
WHERE Email = 'aitrich.academy@aitrich.com';


DELETE FROM Companies WHERE email = 'aitrich.academy@aitrich.com';