SELECT cid, COUNT(*) AS OrderCount
FROM orders
GROUP BY cid;



SELECT c.customername, COUNT(*) AS OrderCount
FROM orders o
JOIN customer c ON o.cid = c.cid
GROUP BY c.customername;

