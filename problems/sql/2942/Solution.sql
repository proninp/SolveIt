SELECT r.name region_name
       , SUM(c.population) total_population
FROM regions r
JOIN cities c ON r.id = c.regionid
GROUP BY r.name