with daily as (
    select date
      , sum(price) daily_gmv
    from sales
    group by date
)
select date
      , daily_gmv
      , sum(daily_gmv) over(order by date) gmv
from daily
order by date