SELECT transaction_id
       , datetime
       , amount
       , user_id
FROM (
    SELECT transaction_id
           , datetime
           , amount
           , user_id
           , COUNT(*) OVER (PARTITION BY datetime, amount, user_id) as duplicated
    FROM purchases) p
WHERE duplicated > 1