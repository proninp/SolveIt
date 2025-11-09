SELECT SUM(s.quantity * p.price) total_revenue
FROM sales s
JOIN prices p ON s.art = p.art
WHERE s.shop = 100 AND s.datetime >= '2024-01-01 00:00:00' AND s.datetime < '2024-01-02'