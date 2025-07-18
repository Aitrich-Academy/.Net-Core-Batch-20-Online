create Table English(Id int PRIMARY KEY, name varchar(50), actor varchar(50),actress varchar(50),director varchar(50));
insert into English values(1,'Interstellar', 'Matthew McConaughey','Jessica','Christopher Nolan');
insert into English values(2,'Titanic', 'Leonardo Dicaprio','Kate Winslet','James Cameron');

create Table Malayalam(Id int PRIMARY KEY, name varchar(50), actor varchar(50),actress varchar(50),director varchar(50));
insert into Malayalam values(1,'Bheeshma Parvam', 'Mammootty','Nadiya Moidu','Amal Neerad');


create Table Tamil(Id int PRIMARY KEY, name varchar(50), actor varchar(50),actress varchar(50),director varchar(50));
insert into Tamil values(1,'Leo', 'Vijay','Trisha','Lokesh');

create Table Telugu(Id int PRIMARY KEY, name varchar(50), actor varchar(50),actress varchar(50),director varchar(50));
insert into Telugu values(1,'Bahubali', 'Prabhas','Anushka','S.Rajamouly');

create Table Hindi(Id int PRIMARY KEY, name varchar(50), actor varchar(50),actress varchar(50),director varchar(50));
insert into Hindi values(1,'Devadas', 'Shah Rukh Khan','Aishwarya Rai','Sanjay Leela Bansaly');

select * from English where actor like '%a%';

select * from Malayalam;
select * from English;
select * from Tamil;
select * from Telugu;
select * from Hindi;

update Malayalam set name= 'Thudarum' where id=1;
update Malayalam set actor= 'Mohanlal' where id=1;
update Malayalam set actress= 'Shobhana' where id=1;
update Malayalam set director= 'Tharun Moorthy' where id=1;

Create Procedure GetTamilfilms
As
Begin 
    select * from Tamil;
End;
Exec GetTamilfilms;



