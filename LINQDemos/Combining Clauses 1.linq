<Query Kind="Expression" />

// List all the menu items that are Entrees 
// in order from most to least expensive
from food in Items
orderby food.CurrentPrice descending
where food.MenuCategory.Description == "Entree"
select food