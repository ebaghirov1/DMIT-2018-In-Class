<Query Kind="Expression" />

// List all the menu items that are Entrees or Beverages
// in order from most to least expensive
from food in Items

where food.MenuCategory.Description == "Entree"
   || food.MenuCategory.Description == "Beverage"
   
orderby food.CurrentPrice descending

group food by food.MenuCategoryID into result

select result