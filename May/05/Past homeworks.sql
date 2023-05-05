/*
1. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların bütün column'larını gətir.
2. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların FirstName, MiddleName, LastName column'larını FullName adı olaraq gətir.
3. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların bütün column'larını gətir.
4. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların BusinessEntityID column'unun toplamını Total adı olaraq gətir.
5. Person.Address table'ından bütün dataları gətir. Ancaq PostalCode column'una görə A-dan Z'yə (artan) sırala.
6. Person.Address table'ından bütün dataları gətir. Ancaq City column'una görə Z-dən A'ya (azalan) sırala.
7. Person.Address table'ından City column'una görə qruplaşdıraraq neçə adres olduğunu çıxardın. Yəni hər şəhər üçün neçə adres məlumatı var? Eyni zamanda da şəhər sayına görə azalan sıralama edin.
*/
select * from Person.Person where FirstName in ('Scott', 'Frank', 'Eric'); --1
select FirstName + ' ' + MiddleName + ' ' + LastName Fullname from Person.Person where FirstName in ('Scott', 'Frank', 'Eric'); --2
select * from Person.Person where FirstName not in ('Eugene', 'Barry', 'Jack'); --3
select sum(BusinessEntityID) Total from Person.Person where FirstName not in ('Eugene', 'Barry', 'Jack'); --4
select * from Person.Address order by PostalCode asc --5
select * from Person.Address order by City desc --6
select City, count(AddressID) CountOfAddressPerCity from Person.Address group by City order by CountOfAddressPerCity desc --7



/*
1. Production.Product table'ından ProductID'si 20-dən böyük olan məlumatların bütün column'larını gətir.
2. Production.Product table'ından ProductID'si 20-dən kiçik olan məlumatların bütün column'larını gətir.
3. Production.Product table'ından ListPrice'ı 200-dən böyük, 500-dən kiçik olan məlumatların ProductID, Name və ListPrice column'larını gətir.
4. Production.Product table'ından SafetyStockLevel'i 900-dən böyük, 1500-dən kiçik olan və ProductID'si 10 olmayan məlumatların bütün column'larını gətir.
5. Production.Product table'ından ProductNumber'ı 'BA-8327' olmayan, Color'u 'Black' olan ilk 50 dənə məlumatın bütün column'larını gətir.
6. Production.Product table'ından ListPrice'ı 500-dən kiçik və ya bərabər olan məlumatların 50%'ni gətir.
7. Production.Product table'ından ListPrice'ı 1001-dən böyük və ya bərabər olan məlumatların 25%'ni gətir.
8. Production.Product table'ından Color'u 'Black' və ya 'Red' olan, Color'u 'Yellow' olmayan məlumatların bütün column'larını gətir.
9. Production.Product table'ından ProductID'si 100-dən böyük, 500-dən kiçik olan və 300, 500 olmayan məlumatların ProductID column'unu gətir.
10. Production.Product table'ından SafetyStockLevel'i 800 və ya 1000 olan amma Color'u 'Black' və ya 'Blue' olmayan məlumatların bütün column'larını gətir.
11. Person.Address table'ından City, PostalCode və AddressLine1 column'larının dəyərlərini aralarında vergül olmaqla FullAddress column adı ilə çəkin.
*/

select * from Production.Product where ProductID > 20 --1

select * from Production.Product where ProductID < 20 --2

select ProductID, Name, ListPrice from Production.Product where ListPrice > 200 and ListPrice < 500 --3

select * from Production.Product where SafetyStockLevel > 900 and SafetyStockLevel < 1500 and ProductID != 10  --4

select top 50 * from Production.Product where ProductNumber != 'BA-8327' and Color = 'Black' --5

select top 50 percent * from Production.Product where ListPrice <= 500 --6

select top 25 percent * from Production.Product where ListPrice >= 1001 --7

select * from Production.Product where (Color = 'Black' or Color = 'Red') and Color != 'Yellow' --8

select ProductID from Production.Product where ProductID > 100 and ProductID < 500 and ProductID != 300 and ProductID != 500 --9

select * from Production.Product where (SafetyStockLevel = 800 or SafetyStockLevel = 1000) and (Color != 'Black' or Color != 'Blue') --10

select City + ', ' + PostalCode + ', ' + AddressLine1 FullAddress from Person.Address --11


/*
1. Person.PersonPhone table'ından PhoneNumber column'unda 15 rəqəmi olan məlumatların bütün column'larını gətir.
2. Person.PersonPhone table'ından PhoneNumber'i 1 rəqəmilə başlayan məlumatların bütün column'larını gətir.
3. Person.PersonPhone table'ından PhoneNumber'i 15 rəqəmilə bitən məlumatların bütün column'larını gətir.
4. Person.PersonPhone table'ından PhoneNumber column'unda 82 rəqəmi olan məlumatların bütün column'larını gətir.
5. Person.ContactType table'ından Name column'unda a hərfi olan məlumatların bütün column'larını gətir.
6. Person.ContactType table'ından Name'i r hərfilə başlayan məlumatların bütün column'larını gətir.
7. Person.ContactType table'ından Name'i s hərfilə bitən məlumatların bütün column'larını gətir.
8. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan məlumatların bütün column'larını gətir.
9. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan və LastName'ında 'ver' sözü olan məlumatların bütün column'larını gətir.
10. Person.Person table'ından FirstName'i a hərfilə bitən və PersonType'ı ZT olmayan ilk 40 məlumatın bütün column'larını gətir.
*/

select * from Person.PersonPhone where PhoneNumber like '%15%' --1
select * from Person.PersonPhone where PhoneNumber like '1%' --2
select * from Person.PersonPhone where PhoneNumber like '%15' --3
select * from Person.PersonPhone where PhoneNumber like '%82%' --4
select * from Person.ContactType where Name like '%a%' --5
select * from Person.ContactType where Name like 'r%' --6
select * from Person.ContactType where Name like '%s' --7
select * from Person.Person where FirstName like '%a' and LastName like 'o%' --8
select * from Person.Person where FirstName like '%a' and LastName like 'o%' and LastName like '%ver%' --9
select top 40 * from Person.Person where FirstName like '%a' and PersonType != 'ZT' --10