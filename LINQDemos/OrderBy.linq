<Query Kind="Expression" />

from food in Items
orderby food.Description descending
select food