SELECT e.name
       , b.bonus
FROM employees e
LEFT JOIN bonuses b ON e.emp_id = b.emp_id
WHERE COALESCE(b.bonus,0) < 1000