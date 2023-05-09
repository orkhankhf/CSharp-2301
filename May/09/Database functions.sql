--Digital Functions
--Min & Max
select * from Production.Product;

select max(SafetyStockLevel) MaxValue, min(SafetyStockLevel) MinValue from Production.Product;

select
max(SafetyStockLevel) MaxValue,
min(SafetyStockLevel) MinValue,
Color
from Production.Product
group by Color;


--Count
select count(*) from Production.Product;
select count(*) from Production.Product where SafetyStockLevel = 1000;

select
Color,
Count(*) as TotalCount
from Production.Product
where Color is not null
group by Color;
select * from Production.Product where Color = 'White';



--sum
select sum(SafetyStockLevel) TotalOfStock from Production.Product;


select * from
Sales.SalesOrderHeader SSOH
inner join
Sales.SalesOrderDetail SSOD
on SSOH.SalesOrderID = SSOD.SalesOrderID


select SalesPersonID, * from
Sales.SalesOrderHeader SSOH
inner join
Sales.SalesOrderDetail SSOD
on SSOH.SalesOrderID = SSOD.SalesOrderID

select * from Person.Person where BusinessEntityID = 279



select
concat(PP.FirstName, ' ', PP.LastName) as Fullname
from
Sales.SalesOrderHeader SSOH
inner join
Sales.SalesOrderDetail SSOD
on SSOH.SalesOrderID = SSOD.SalesOrderID
inner join Person.Person PP
on SSOH.SalesPersonID = PP.BusinessEntityID
where
SSOH.OrderDate = '2011-05-31 00:00:00.000'
group by concat(PP.FirstName, ' ', PP.LastName)





--Text Functions

--Lower and Upper
select * from HumanResources.Employee;
select upper(JobTitle), lower(Gender) from HumanResources.Employee;
select upper(lower(JobTitle)), lower(Gender) from HumanResources.Employee;


--Len
select JobTitle, len(JobTitle), Gender, len(Gender) from HumanResources.Employee;


--Concat
select
FirstName + ' ' + Lastname as Fullname
from Person.Person;

select
concat(FirstName, ' ', Lastname) as Fullname
from Person.Person;

select
concat(FirstName, space(1), Lastname) as Fullname
from Person.Person;

select
concat(FirstName, space(50), Lastname) as Fullname
from Person.Person;



--Substring
select 
Name,
substring(Name, 1, 5) SubName
from Production.Product;

select 
Name,
substring(Name, 1, 5) as Name1,
substring(upper(Name), 1, 5) as UpperName
from Production.Product;



--Left and Right
select 
Name,
substring(Name, 1, 5) as Name1,
substring(upper(Name), 1, 5) as UpperName,
left(Name, 3),
right(Name, 3)
from Production.Product;