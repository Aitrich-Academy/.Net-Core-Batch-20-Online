CREATE TABLE product (
  product_id INT IDENTITY(1,1) PRIMARY KEY ,
  product_name VARCHAR(100) NOT NULL
);


INSERT INTO product ( product_name)
VALUES ('AC');


select * from product


