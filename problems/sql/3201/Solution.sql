SELECT r.title
       , COUNT(t.id) old_towns_count
FROM region r
JOIN town t ON t.region_id = r.id
WHERE t.year_ < 1901
GROUP BY r.title
ORDER BY old_towns_count DESC, title ASC