SELECT e1.id id1
       , e2.id id2
FROM employees e1
JOIN employees e2 ON e1.id < e2.id
                     AND ABS(e1.salary - e2.salary) <= 5000