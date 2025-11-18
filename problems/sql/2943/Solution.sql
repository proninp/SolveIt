SELECT AVG(age) average_age
FROM (
    SELECT DISTINCT c.customer_key, c.age
    FROM purchases p
    JOIN products pr ON pr.product_key = p.product_key
    JOIN customers c ON c.customer_key = p.customer_key
    WHERE pr.name = 'Smartwatch' AND p.date >= '2024-01-01'
      AND p.date <  '2025-01-01'
);