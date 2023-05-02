select * from Person.Person;

select BusinessEntityID, FirstName, MiddleName, LastName from Person.Person;

select BusinessEntityID, FirstName + ' ' + MiddleName + ' ' + LastName from Person.Person;

select BusinessEntityID Sira, FirstName Ad, LastName Soyad from Person.Person;

select BusinessEntityID, FirstName + ' ' + MiddleName + ' ' + LastName Fullname from Person.Person;



select * from Person.Address;

select top 20 * from Person.Address;

select top 20 percent * from Person.Address;

select * from Person.Person where FirstName = 'John';
select * from Person.Person where BusinessEntityID = 9;
select * from Person.Person where EmailPromotion = 1;

/*
Task In Lesson 1:
1. Person.EmailAddress table'ından EmailAddressID'si 3 olan məlumatların bütün column'larını gətir.
2. Production.ProductDocument table'ından ProductID'si 517 olan məlumatların bütün column'larını gətir.
3. Sales.Currency table'ından CurrencyCode'u 'AZM' olan məlumatların bütün column'larını gətir.
4. Sales.SalesTerritory table'ından TerritoryID'si 6 olan məlumatların sadəcə Name və CountryRegionCode column'larını gətir.
*/

select * from Person.EmailAddress where EmailAddressID = 3 --1

select * from Production.ProductDocument where ProductID = 517 --2

select * from Sales.Currency where CurrencyCode = 'AZM' --3

select Name, CountryRegionCode from Sales.SalesTerritory where TerritoryID=6; --4


select [group] from Sales.SalesTerritory where TerritoryID=6;




--[Multiple where clause]
--and
select * from Person.Person where FirstName = 'John' and LastName = 'Arthur';
select * from Person.Person where PersonType = 'EM' and BusinessEntityID = 155;

--or
select * from Person.Person where FirstName = 'John' or FirstName = 'Rob';
select * from Person.Person where FirstName = 'Orkhan' or FirstName = 'Rob';

--and - or
select * from Person.Person where FirstName = 'John' or FirstName = 'Rob' and PersonType='IN';
select * from Person.Person where (FirstName = 'John' or FirstName = 'Rob') and PersonType='IN';

select * from Person.Person where FirstName = 'John' or FirstName = 'Rob'



--[Comparsion Operators]
select * from Production.Product;
-- > boyukdur
select * from Production.Product where ListPrice > 500
select * from Production.Product where ListPrice > 200

-- < kicikdir
select * from Production.Product where ListPrice < 650
select * from Production.Product where ListPrice < 50

-- >= boyukdur beraberdir
select * from Production.Product where ListPrice >= 500
select * from Production.Product where ListPrice >= 200

-- <= kicikdir beraberdir
select * from Production.Product where ListPrice <= 120
select * from Production.Product where ListPrice <= 50

-- beraberdir
select * from Production.Product where Color = 'Black'
select * from Production.Product where Color = 'Yellow'

-- deyilse beraber
select * from Production.Product where Color != 'Black'
select * from Production.Product where Color != 'Yellow'


--[Like Operator]
-- a herfile baslayan
--like 'a%'

-- a herfile biten
--like '%a'

-- icinde a herfi olan
--like '%a%'

select * from Person.Person where FirstName like 'a%';
select * from Person.Person where FirstName like '%a';
select * from Person.Person where FirstName like '%a%';

select * from Person.Person where FirstName like '%al';
select * from Person.Person where FirstName like '%son%';


--------Asagidaki kodlarin ev ve praktiki tapsiriqlari homework faylinda da ayrilib diqqetli olun--------
--------Asagidaki kodlarin ev ve praktiki tapsiriqlari homework faylinda da ayrilib diqqetli olun--------
--------Asagidaki kodlarin ev ve praktiki tapsiriqlari homework faylinda da ayrilib diqqetli olun--------



--[IN - NOT IN]
select * from Production.Product;

select * from Production.Product where
ProductNumber = 'AR-5381' or
ProductNumber = 'BA-8327' or
ProductNumber = 'BE-2349' or
ProductNumber = 'BE-2908' or
ProductNumber = 'BL-2036';

select * from Production.Product where
ProductNumber
IN ('AR-5381', 'BA-8327', 'BE-2349', 'BE-2908', 'BL-2036')

select * from Production.Product where
ProductNumber != 'AR-5381' and
ProductNumber != 'BA-8327' and
ProductNumber != 'BE-2349' and
ProductNumber != 'BE-2908' and
ProductNumber != 'BL-2036';

select * from Production.Product where
ProductNumber
NOT IN ('AR-5381', 'BA-8327', 'BE-2349', 'BE-2908', 'BL-2036')

--[Order By (sorting)]
select * from Production.Product where Name like '%a%'
select * from Production.Product where Name like '%a%' order by ProductID

select * from Production.Product where Name like '%a%' order by Name

select * from Production.Product where Name like '%a%' order by Name desc

select * from Production.Product where Name like '%a%' order by ProductID desc


select * from Sales.Store order by SalesPersonID
select * from Sales.Store order by SalesPersonID asc

select * from Sales.Store order by SalesPersonID desc


select * from Sales.Store order by Name asc
select * from Sales.Store order by Name desc

--A-Z siralama: asc (ascending)
--Z-A siralama: desc (descending)
--1-N
--N-1




--[Group By]
select * from Production.Product

select * from Production.Product where Color is not null

select Color, SUM(SafetyStockLevel) StockLevel, AVG(ListPrice) AvgPrice from Production.Product
where Color is not null
group by Color

select Color, SUM(SafetyStockLevel) StockLevel, AVG(ListPrice) AvgPrice from Production.Product
group by Color



--[Distinct]
select * from Production.Product
select distinct Color from Production.Product
select distinct Color, Name from Production.Product



select * from Sales.SalesOrderDetail
select distinct ProductID from Sales.SalesOrderDetail

select * from Production.Product
where
ProductID IN
(
	select distinct ProductID from Sales.SalesOrderDetail
)


select Color, sum(ListPrice) from Production.Product
where
ProductID IN
(
	select distinct ProductID from Sales.SalesOrderDetail
)
group by Color



--[Between]
select * from Production.Product

select * from Production.Product where ListPrice >= 50 and ListPrice <= 100

select * from Production.Product where ListPrice between 50 and 100