<Query Kind="Expression" />

from cat in MenuCategories
orderby cat.Description
select new
{
	Description = cat.Description,
	MenuItems = from item in cat.Items
	            where item.Active
				orderby item.Description
				select new
				{
					Description = item.Description,
					Price = item.CurrentPrice,
					Calories = item.Calories,
					Comment = item.Comment
				}
}