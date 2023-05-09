/*
Homework 1:
	Kod yazaraq aşağıdakı table'ı yaradın. Sonra, UI tərəfdə də eynisini edin sadəcə table adının sonuna UI yazın ki, eyni adda iki table olmaz.
	Həm kod, həm də UI tərəfdə bu iki table'ı yaratdıqdan sonra UI ilə yaratdığınızı silə bilərsiniz. Sadəcə məşğələ məqsədi daşıyır. Ancaq Personals
	lazım olacaq. Yaradandan sonra aşağıdakı text'i oxuyun...

	Personals:
		id rəqəm avtomatik artan deyer, boş buraxıla bilməz, təkrarlana bilməz (avtomatik artan dəyəri necə yazacağınızı araşdırın)
		name (50 simvollu mətn), boş buraxıla bilməz
		surname (50 simvollu mətn), boş buraxıla bilməz
		email (250 simvollu mətn), boş buraxıla bilməz, eynisi olmamalıdır
		gender (bunu araşdırın ki, 1 simvolu hansı tip datada saxlaya bilərsiniz? bit olmasın.)
		createdDate ,default olaraq indiki zamanı alsın, boş ola bilməz
		updatedDate boş ola bilər
		isDeleted boş olduğu halda false olsun

	Aşağıda yazdığım select sorğusu sizə AdventureWorks database'indən müəyyən datalar qaytaracaq. Sizin etməli olduğunuz, aşağıdakı sorğuda sizə gələn
	dataları, yuxarıda yaratdığınız Personals table'ınıza insert etməyinizdir. Ad, Soyad, Cinsiyyət select sorğusundan gəldiyi kimi daxil ediləcək. Email
	ünvanı isə, ad.soyad@gmail.com formatında olacaq. Məsələn orxan.ferecov@gmail.com.
	Aşağıdakı sorğuda sizə gələn ad və soyad ilə email generate edəcəksiniz. Ad və soyad böyük hərflə başlayır. Siz araşdırma edərək ad və soyad'dan email
	generate edən zaman ad və soyad'ı kiçik hərflərə çevirməyi tapmalısınız. yəni Orxan Ferecov üçün orxan.ferecov@gmail.com generate olunacaq. Bu taskı
	etmək üçün, internetdən araşdırma etməlisiniz. Bir select sorğusundan gələn nəticəni başqa table'a insert etməyi öyrənməlisiniz.

	select * from Person.Person as PP
	inner join HumanResources.Employee HRE on
	PP.BusinessEntityId = HRE.BusinessEntityId



	Homework 2:
	Aşağıda yazdığım select sorğusunda hər iki table'dan column'lar gəlir. Siz elə etməlisiniz ki,
	BusinessEntityID column'u Id olaraq, Firstname column'u Name olaraq, LastName column'u Surname olaraq, əlavə Email column'u Firstname və Lastname'dən 
	istifadə edərək kiçik hərflə orkhan.farajov@gmail.com olaraq, Gender, əlavə Date column'unda indiki tarixi almalısınız.

	select * from Person.Person as PP
	inner join HumanResources.Employee HRE on
	PP.BusinessEntityId = HRE.BusinessEntityId
*/

/*Homework 1*/
create table Personals
(
	Id int primary key IDENTITY(1,1),
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	Email nvarchar(250) unique not null,
	Gender nchar(50),
	CreatedDate datetime not null default getdate(),
	UpdatedDate datetime null,
	IsDeleted bit default 'false'
)

insert into Personals (Name, Surname, Email, Gender)
select 
PP.FirstName,
PP.LastName,
(lower(PP.FirstName) + '.' + lower(PP.LastName) + '@gmail.com') as Email,
HRE.Gender
from Person.Person as PP
inner join HumanResources.Employee HRE on
PP.BusinessEntityId = HRE.BusinessEntityId



/*Homework 2*/
select 
PP.BusinessEntityID Id,
PP.FirstName Name,
PP.LastName Surname,
(lower(PP.FirstName) + '.' + lower(PP.LastName) + '@gmail.com') as Email,
HRE.Gender,
getdate() as Date
from Person.Person as PP
inner join HumanResources.Employee HRE on
PP.BusinessEntityId = HRE.BusinessEntityId