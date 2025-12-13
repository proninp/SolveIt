SELECT p.name
       , COUNT(o.order_id) usage_count
FROM promocodes p
JOIN orders o ON p.promocode_id = o.promocode_id
GROUP BY p.name
ORDER BY usage_count DESC
LIMIT 1