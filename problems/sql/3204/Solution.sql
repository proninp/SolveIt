SELECT shop_id
FROM orders
GROUP BY shop_id
HAVING COUNT(id) > 50