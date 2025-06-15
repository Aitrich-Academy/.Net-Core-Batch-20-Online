

----	Show All Details Of Company Member in Company Aitrich Academy

 select 
 u.FirstName ,
 u.LastName , 
 u.Email ,
 u.Phone ,
 c.Name 
 from
 users u,
 companies c
 where 
 u.CompanyId=c.Id and c.Name='Aitrich Academy' 
