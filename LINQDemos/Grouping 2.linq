<Query Kind="Expression" />

from food in Items
group food by new {food.MenuCategoryID, food.CurrentPrice}
// No need for the select clause if all you want is grouping