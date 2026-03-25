select user_id
from orders
group by user_id
having sum(case when event_type = 'концерт' then 1 else 0 end) > 0
    and
       sum(case when event_type = 'театр' then 1 else 0 end) = 0