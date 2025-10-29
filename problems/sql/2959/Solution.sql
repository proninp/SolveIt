SELECT event_date
       , client_id
       , sum_profit
       , profit_ratio
FROM (
    SELECT event_date
           , client_id
           , sum_profit
           , ROUND(sum_profit * 1.0 / (LAG(sum_profit) OVER (
                PARTITION BY client_id ORDER BY client_id, event_date)), 2) profit_ratio
    FROM client_profit
) res
WHERE res.profit_ratio IS NOT NULL
ORDER BY event_date, client_id