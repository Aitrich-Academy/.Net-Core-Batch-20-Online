SELECT c.cid, c.customername, COUNT(*) AS total_orders
FROM orders o
JOIN customer c ON o.cid = c.cid
GROUP BY c.cid, c.customername
HAVING COUNT(*) > 5
ORDER BY total_orders DESC;

INSERT INTO orders (cid, orderdate) VALUES (7, '2024-05-03');

