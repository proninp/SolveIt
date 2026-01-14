SELECT sku
       , date
       , CASE WHEN value iS NULL THEN
            (SELECT p1.value
             FROM products p1 
             WHERE p1.value IS NOT NULL and
                   p1.sku = p.sku and p1.date < p.date
             ORDER BY date DESC
             LIMIT 1)
        else
            p.value
        end filled_value
FROM products p