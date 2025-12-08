SELECT e.unit_id
       , MIN(e.salary) min_salary
       , MAX(e.salary) max_salary
FROM employees e
WHERE e.fired = 0
GROUP BY e.unit_id
ORDER BY unit_id