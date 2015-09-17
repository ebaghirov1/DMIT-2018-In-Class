<Query Kind="Expression" />

from food in Items
where food.MenuCategory.Description == "Entree" && food.Active
orderby food.CurrentPrice descending
select new
{
	Description = food.Description,
	Price = food.CurrentPrice,
	Calories = food.Calories
}