SELECT e.department_id
    , COUNT(e.id) employee_count
FROM employees e
GROUP BY e.department_id
HAVING COUNT(e.id) < 11