select c.customer_phone customer_phone
       , COUNT(o.id) orders_count
from orders o
join calls c on o.call_id = c.id
GROUP BY c.customer_phone
HAVING COUNT(o.id) > 1