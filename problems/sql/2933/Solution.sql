SELECT DISTINCT name
       , FIRST_VALUE(price) OVER(PARTITION BY name ORDER BY date DESC) price
FROM currency