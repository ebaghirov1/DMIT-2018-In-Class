<Query Kind="Expression">
  <Connection>
    <ID>1c87d643-3eb0-4fb9-a6ae-337d80b9f4af</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from row in Tables
where row.Capacity > 3
select row