SELECT id
FROM (
    SELECT id
           , email
           , ROW_NUMBER() OVER(PARTITION BY email ORDER BY id) rownum
    FROM users) sub
WHERE rownum > 1