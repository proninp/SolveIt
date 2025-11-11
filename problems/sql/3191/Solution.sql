SELECT item_id
       , name
       , price
       , update_date
FROM (
    SELECT item_id
           , name
           , price
           , update_date
           , ROW_NUMBER() OVER(PARTITION BY item_id ORDER BY update_date DESC) rn
    FROM items
    WHERE update_date < '2025-12-18') q
WHERE rn = 1
