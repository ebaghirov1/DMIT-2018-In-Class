<Query Kind="Expression" />

from food in Items
group food by food.MenuCategory into foodGroup
select new
{
	CategoryID = foodGroup.Key.MenuCategoryID,
	Category = foodGroup.Key.Description,
	Count = foodGroup.Count(),
	MenuItems = foodGroup.ToList()
}