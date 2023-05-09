--Stored procedures
insert into Staffs
(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
values
('Orkhan', 'Farajov', 'orkhankhf@gmail.com', getdate(), null, 0);

select * from Staffs


--Nümunə procedure yaratmaq
create proc some_procedure_name
(
--Qebul edeceyi parametrler
@id int,
@name nvarchar(50)
)
as
begin
--procedure'un body hissesi
select 1;
end



--Yeni bir Staff inserti funksiyasını yerinə yetirən procedure yaratmaq
create proc spAddNewStaff
(
@name nvarchar(50),
@surname nvarchar(50),
@email nvarchar(50)
)
as
begin
insert into Staffs
(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
values
(@name, @surname, @email, getdate(), null, 0);
end



--procedure'u çağırmaq/işə salmaq
exec spAddNewStaff @name='Orkhan3', @surname='Farajov', @email='okvrf';


create proc spGetStaffs
as
begin
	select * from Staffs;
end

exec spGetStaffs;


-----------------------------------------------------------------------
--Edit and delete stored procedures
alter proc spAddNewStaff
(
@name nvarchar(50),
@surname nvarchar(50),
@email nvarchar(50)
)
as
begin
insert into Staffs
(Name, Surname, Email, CreateDate, EditDate, IsDeleted)
values
(@name, @surname, @email, getdate(), getdate(), 0);
end


drop proc spAddNewStaff;

-----------------------------------------------------------------------------------

--Encryption of Stored Procedures
create proc spAddBook
(
@name nvarchar(50),
@author nvarchar(50),
@page int
)
with encryption
as
begin
insert into Books
(Name, Author, Page, CreateDate, EditDate, IsDeleted)
values
(@name, @author, @page, getdate(), null, 0);
end


--alter proc spAddBook
--(
--@name nvarchar(50),
--@author nvarchar(50),
--@page int
--)
--as
--begin

--end


--Optional Procedure Parameters
--Aşağıdakı kod üçün adventureWorks'dan istifadə edin
create proc spGetEmployees
(
@gender char(1) = 'M'
)
with encryption
as
begin
	select * from HumanResources.Employee where Gender = @gender;
end

exec spGetEmployees --Default value ilə işləyəcək
exec spGetEmployees @gender = 'F';