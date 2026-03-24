SELECT ROUND(
    COUNT(*) FILTER (WHERE promocode_id IS NOT NULL) * 100.0 / 
    COUNT(*), 2) promo_orders_percentage
FROM orders