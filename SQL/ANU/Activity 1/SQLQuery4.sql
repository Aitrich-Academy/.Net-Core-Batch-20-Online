SELECT cid, COUNT(*) AS total_orders
FROM orders
GROUP BY cid
ORDER BY total_orders DESC;


 
 SELECT c.cid ,c.customername ,COUNT(*) AS total_orders
FROM  orders o
JOIN customer c ON o.cid = c.cid
GROUP BY c.cid, c.customername
ORDER BY total_orders DESC;