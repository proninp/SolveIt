select i.seller_id
       , sum(s.price) total_sales_value
from sales s
join items i on s.item_id = i.item_id
group by i.seller_id