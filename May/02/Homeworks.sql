/*
Praktiki tapsiriqlar 1:
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

Praktiki tapsiriqlar 2:
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


VACİB QEYD: Taskların heç birini edərkən qətiyyən copy-paste etməyin. Bütün sorğuları bir-bir özünüz yazın.

Bütün taskları Adventure Works database'ində işləyəcəksiniz. Table seçimlərini sizə həvalə edirəm.

Homework 1:
Ən az 10 fərqli table'dan məlumat select edin.

Homework 2:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 1 column'a şərt qoyun.

Homework 3:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (and ilə).

Homework 4:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (or ilə).
	
Homework 5:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (and ilə).

Homework 6:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (or ilə).

Homework 7:
Ən az 6 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 3-4 column'a şərt qoyun (and və or ilə).

Homework 8:
5 fərqli table'dan ilk 5, 10, 15, 20, 25 məlumatı çəkməyə çalışın. Birindən ilk 5, digərindən ilk 10 və s.

Homework 9:
Sales.SalesOrderDetail table'dan CarrierTrackingNumber'ində 480 rəqəmi keçən, OrderQty'i 15 olmayanları gətirin.
	
Homework 10:
Sales.SalesOrderDetail table'dan UnitPrice'ı 250-dən böyük və ya bərabər olan amma 125 olmayan,
ProductID'si 1-dən böyük və 1000-dən kiçik və ya bərabər olanları gətirin
*/




--------Asagidaki ev ve praktiki tapsiriqlar queries faylinda ayrilib diqqetli olun--------
--------Asagidaki ev ve praktiki tapsiriqlar queries faylinda ayrilib diqqetli olun--------
--------Asagidaki ev ve praktiki tapsiriqlar queries faylinda ayrilib diqqetli olun--------



/*
(IN və NOT IN keçəndən sonrakı hissələrin praktiki və ev tapşırıqları)
Part 3:
1. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların bütün column'larını gətir.
2. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların FirstName, MiddleName, LastName column'larını FullName adı olaraq gətir.
3. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların bütün column'larını gətir.
4. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların BusinessEntityID column'unun toplamını Total adı olaraq gətir.
5. Person.Address table'ından bütün dataları gətir. Ancaq PostalCode column'una görə A-dan Z'yə (artan) sırala.
6. Person.Address table'ından bütün dataları gətir. Ancaq City column'una görə Z-dən A'ya (azalan) sırala.
7. Person.Address table'ından City column'una görə qruplaşdıraraq neçə adres olduğunu çıxardın. Yəni hər şəhər üçün neçə adres məlumatı var? Eyni zamanda da şəhər sayına görə azalan sıralama edin.
*/