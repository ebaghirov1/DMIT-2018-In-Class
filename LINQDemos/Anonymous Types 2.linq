<Query Kind="Expression" />

// Anonymous Types 2.linq
from person in Waiters
where person.ReleaseDate == null   // People still employed
select new
{
	Name = person.FirstName + " " + person.LastName,
	Phone = person.Phone,
	DaysEmployed = (DateTime.Today - person.HireDate).Days
}