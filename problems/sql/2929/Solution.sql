SELECT u.id user_id
       , u.name user_name
       , SUM(o.quantity * p.price) total_order_value
FROM products p
JOIN categories c ON c.id = p.category_id
JOIN orders o ON o.product_id = p.id
JOIN users u ON u.id = o.user_id
WHERE c.name = 'Electronics'
GROUP BY u.id
         , u.name