SELECT e.name
FROM employees e
JOIN employees c ON e.chief_id = c.id
WHERE e.chief_id IS NOT NULL AND c.salary < e.salary