--Customers (table) (əgər 1 email və 1 telefon olacaqsa düz struktur)
		--Id
		--Name
		--Surname
		--Gender
		--BirthDate
		--Email
		--PhoneNumber
---------------------------------------------------------
--Customers (table) (Səhv struktur)
		--Id
		--Name
		--Surname
		--Gender
		--BirthDate
		--Email
		--PhoneNumber1
		--PhoneNumber2
		--PhoneNumber3
		--PhoneNumber4
		--PhoneNumber5
		--PhoneNumber6
		--PhoneNumber7
---------------------------------------------------------
--Customers (table)
		--Id
		--Name
		--Surname
		--Gender
		--BirthDate

--ContactTypes (table) (Nümunə data: 1. Phone, 2. Email, 3. Faks)
		--Id
		--Name

--Contacts (table)
		--Id
		--CustomerId (Customers table'ındakı müştərinin Id'si burada saxlanılacaq)
		--ContactTypeId (ContactTypes table'ındakı əlaqə növünün Id'si burada saxlanılacaq)
		--Value

select * from Person.Person
select * from Person.EmailAddress where EmailAddressID = 12;



--[Inner join]
select * from Person.Person
select * from Person.EmailAddress

select * from Person.Person
inner join Person.EmailAddress
on Person.BusinessEntityID = EmailAddress.EmailAddressID

select * from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.EmailAddressID

select 
pp.BusinessEntityID,
pp.Firstname,
pp.MiddleName,
pp.LastName,
pea.EmailAddress
from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.EmailAddressID



--[Left Join]
select * from Person.Person
select * from Person.ContactType

select * from Person.Person pp
left join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID

select 
pp.BusinessEntityID,
pp.FirstName,
pp.MiddleName,
pp.LastName,
pct.*
from Person.Person pp
left join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID
order by pp.BusinessEntityID asc




--[Right Join]
select * from Person.Person
select * from Person.ContactType

select * from Person.Person pp
right join Person.ContactType pct
on pp.BusinessEntityID = pct.ContactTypeID




--[Sub Query]
select * from Person.Person
select * from Person.EmailAddress

select 
pp.Firstname,
pp.LastName,
pea.EmailAddress
from Person.Person pp
inner join Person.EmailAddress pea
on pp.BusinessEntityID = pea.EmailAddressID

select
Firstname,
LastName,
(select EmailAddress from Person.EmailAddress where EmailAddressID = Person.BusinessEntityID) as Email
from Person.Person;






--Database yaratmaq
create database School

--Database silmek
drop database School

--Table yaratmaq
create table Students(
	Id int,
	Name nvarchar(100), --metn tipi, max uzunlugu da 100 simvol olsun
	Surname nvarchar(100) --metn tipi, max uzunlugu da 100 simvol olsun
);

--Table silmek
drop table Students;

--Movcud table'a column elave etmek
alter table Students
add CreateDate datetime

alter table Students
add TestColumn datetime

--Column silmek
alter table Students
drop column TestColumn

--column tipine mudaxile
alter table Students
alter column Name nvarchar(250)






--[Restrictions]

--Not Null
create table Persons(
	Id int,
	Name nvarchar(100),
	Surname nvarchar(100)
);

create table PersonsWithNotNull(
	Id int not null,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
);


--Unique
create table NotConstraintUniqueTest(
	Id int not null, --Id tekrarlana biler
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Email nvarchar(255) not null, --Email tekrarlana biler
);

create table ConstraintUniqueTest(
	Id int not null unique, --Id tekrarlana BILMEZ
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Email nvarchar(255) not null unique, --Email tekrarlana BILMEZ
);


--Primary Key
create table Employee(
	Id int not null unique, --Id null ola ve tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
);

create table EmployeePKey(
	Id int primary key, --Id null ola ve tekrarlana bilmez
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
);


--Check
create table EmployeeConstraintCheck(
	Id int primary key,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Age int not null check(Age >= 18)
);

create table StudentsConstraintCheck(
	Id int primary key,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	Age int not null check(Age <= 35)
);


--Default
select getdate();

create table ConstraintDefault(
	Id int primary key,
	Name nvarchar(100) not null default 'Ad daxil edilmeyib',
	Surname nvarchar(100) not null,
	Age int not null default 18 check(Age >= 18),
	CreateDate datetime default getdate()
);




--[Table Relations]
create table Customers( --without relation
	Id int primary key, 
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	DocumentNumber int not null,
	DocumentSerial nvarchar(2) not null
);

create table Addresses( --without relation
	Id int primary key, 
	FullAddress nvarchar(500) not null,
);

drop table Customers
drop table Addresses


create table Customers(
	Id int primary key, 
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	DocumentNumber int not null,
	DocumentSerial nvarchar(2) not null
);

create table Addresses(
	Id int primary key, 
	FullAddress nvarchar(500) not null,
	CustomerId int,
	foreign key (CustomerId) references Customers(Id)
);




--[Insert]
select * from Students;

insert into Students (Id, Name, Surname, EmailAddress) values (200, '', '', 'orkhankhf@gmail.com')




--[Update]
update Students set Surname = 'Ferecov' where Id = 3

update Students set Surname = 'Farajov', EmailAddress='orkhan@gmail.com' where Id = 3

update Students set Name= 'Royal', Surname = 'Humbetov'


--[Delete]
delete Students

delete Students where Id = 2
delete Students where Id > 2
delete Students where Id >= 5


delete Students where Name = '' and Surname = ''

delete Students where Name = '' and Surname = '' or Id > 100