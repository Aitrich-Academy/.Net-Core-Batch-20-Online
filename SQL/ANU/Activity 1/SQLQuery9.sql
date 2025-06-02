select * from orders 

select * from product 


SELECT product_id , COUNT(*) AS Occurrences
FROM Orders
GROUP BY product_id 
HAVING COUNT(*) > 1;

