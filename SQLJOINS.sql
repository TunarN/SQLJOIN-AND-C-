Create Table Country
(
Id int primary key identity,
Name nvarchar(50),
Population decimal (18,2),
Area decimal (18,2)
)

Create Table City
(
Id int primary key identity,
Name nvarchar(50),
Population decimal (18,2),
Area decimal (18,2),
CountryId int references Country(Id)
)

select * from Country

select c.Name 'CityName',c.Population 'CityPopulation',c.Area,cn.Name 'CountryName' from City c

Inner Join Country cn
on
c.CountryId = cn.Id

select c.Name 'CityName',c.Population 'CityPopulation',c.Area,cn.Name 'CountryName' from City c

Left Join Country cn
on
c.CountryId = cn.Id

select c.Name 'CityName',c.Population 'CityPopulation',c.Area,cn.Name 'CountryName' from City c

Right Join Country cn
on
c.CountryId = cn.Id

select c.Name 'CityName',c.Population 'CityPopulation',c.Area,cn.Name 'CountryName' from City c

Full Join Country cn
on
c.CountryId = cn.Id

create table Positions
(
Id int primary key identity,
Name nvarchar (50),
DependId int 
)

SELECT p.Name 'PositionName' , p1.Name 'DependedName' FROM Positions p , Positions p1
Where p.DependId = p1.Id

create table Products
(
Id int primary key identity,
Name nvarchar (50),
)

create table Sizes
(
Id int primary key identity,
Name nvarchar (50),
)
Select*from(
Select p.Name 'ProductName' , s.Name 'ProductSize' From Products p 
Cross Join 
Sizes s ) p Order by ProductName asc

create table Students
(
Id int primary key identity,
Name nvarchar (50),
Point int
)

create table Grades
(
Id int primary key identity,
Name nvarchar (50),
Point int
)

Alter Table Grades add Minpoint int
exec sp_rename 'Grades.Point',MaxPoint

Select s.Name , s.Point , g.Name 'PointName' From Students s , Grades g
Where s.Point BETWEEN g.MinPoint AND g.MaxPoint
