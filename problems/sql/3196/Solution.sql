SELECT SUM(price) total_sales
FROM items i
JOIN orders o ON o.item_id = i.item_id
     and i.update_date = (SELECT MAX(i2.update_date)
                          FROM items i2
                          WHERE i2.item_id = o.item_id AND i2.update_date <= o.order_date)
WHERE o.order_date < '2026-02-02'