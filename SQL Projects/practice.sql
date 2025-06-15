create login John_login with password = 'john123';
use shops;
create user john_user for login John_login;

grant select,insert on employess12 to john_user; 

