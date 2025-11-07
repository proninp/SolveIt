SELECT u.id user_id
       , u.first_name
       , u.last_name
       , p.sku
FROM users u
JOIN purchases p ON u.id = p.user_id
LEFT JOIN ban_list bl ON bl.user_id = u.id
WHERE bl.date_from IS NULL OR p.date < bl.date_from
ORDER BY u.first_name, p.sku