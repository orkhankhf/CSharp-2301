use AdventureWorks2017;

select * from AdventureWorks2017.Person.Address;

--This is single line comment

/*
This
is
multi
line
comment
*/

use AdventureWorks2017; --Hansı database'i istifadə etsin aşağıdakı kodlar üçün onu bildirirsiniz.

--Select: Table'dan məlumatları çəkən əmr
--From: Haradan və ya hansı qaynaqdan məlumatları götürəcəyini bildirir.

--Yazılış qaydası: select column_adları (və ya) * from table_adi
select * from Person.Address; --Address table'ında olan bütün column'ları (sütunları) gətir.

select AddressId, AddressLine1, City, PostalCode, ModifiedDate from Person.Address;
