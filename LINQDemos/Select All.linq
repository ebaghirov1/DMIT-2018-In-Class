<Query Kind="Expression" />

from data in Waiters
where data.ReleaseDate == null
select data