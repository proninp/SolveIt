SELECT user_id
       , dttm
FROM user_logs
GROUP BY user_id
       , dttm
HAVING COUNT(*) > 1