-----	Update the name of the Dean ‘Renuka Sharma’ to Renuka Mukerjee’.


select * from dean 


insert into dean (deanname,DateOfBirth ) values ('Renuka Sharma','1965-03-15 00:00:00.000')

update dean set DeanName ='Renuka Mukerjee' where DeanID =22;

--------------------------------------------------------------------

---	Update the phone number of student ‘alice’ to ‘8105874639’

select * from student

update student set telephonenumber='8105874639' where studentId=1


