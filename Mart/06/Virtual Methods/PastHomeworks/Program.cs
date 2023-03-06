using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework:
              Ev tapşırığında bir elektronik mağazanın satış sistemi yığılacaq. Mən məhsulların class property'lərini verəcəyəm
              onların necə yaradılacağına, neçə dənə inheritance alınacağına və s. qarışmıram.
              Laptop class'ında olacaq propertylər: Id, Barcode, Brand, Model, BuyPrice, SellPrice, OfferPrice, CPU, Ram, GraphicCard, CreateDate, CreateUser, EditDate, EditUser, IsDeleted, DeleteDate, DeleteUser;
              Tv class'ında olacaq propertylər: Id, Barcode, Brand, Model, BuyPrice, SellPrice, OfferPrice, IsSmartTv, HasHDMI, Resolution, CreateDate, CreateUser, EditDate, EditUser, IsDeleted, DeleteDate, DeleteUser;
              Deməli burada 2 dənə ayrı class olacaq. Laptop və TV. Bunlar özü başqa base class və ya ortaq property'lərin olduğu bir və ya bir neçə class'dan
              inherit ala bilər. Ancaq başqa bir class Tv və Laptop class'ından inherit ala bilməsin.
              Bir class daha yaranmalıdır. Hansı ki, içində bir arrayList olacaq və ona kənardan heç bir müdaxilə edilə bilməsin.
              Bu arrayList database kimi istifadə ediləcək. Eyni zamanda class'ın içində NewItem, NewItems, UpdateItem, DeleteItem methodları olacaq.
              Bu methodların heç birinin parametrinin tipi Tv, Laptop, object, dynamic və ya .NET'in hər hansısa tipində ola BİLMƏZ! Bunu biraz düşünmək lazım olacaq :)
              -NewItem methodu bir parametr almalıdır. NewItem array'a tək məhsul əlavə edəcək.
              -NewItems methodu təyin olunan zaman 1 parametr yazılacaq ancaq istifadə edilən yerdə istədiyim qədər Tv və ya Laptop tipində fərqli
               dəyişənlər ötürə biləcəm. Məsələn NewItems(Laptop, Tv, Tv, Tv, Laptop, Laptop...).
              -UpdateItem methodu isə hər hansısa məhsulun dəyərlərini update edəcək.
              -DeleteItem məhsulu silməyəcək sadəcə IsDeleted true olacaq.
              
              Id dəyəri hər dəfə Laptop və ya Tv yaradılan zaman özü artsın (random yox). Set oluna bilməsin. Get oluna bilər. Update də olunmasın.
              Barcode dəyəri təkrarlana bilməz. Təkrar əlavə edilməyə cəhd edilsə "Bu barkod daha once basqa mehsul ucun sisteme elave olunub!" yazısı çıxsın. 
              Yalnız IsDelete true olan bir məhsulun barkodu təkrar başqa məhsul üçün əlavə oluna bilər. İşinizi asanlaşdırmaq üçün bunu check edən bir method 
              yazın database class'ınızın içində.
              BuyPrice mağazanın topdan alış qiymətidir. 1-dən kiçik ola bilməz. Xəta mesajı: "Alis qiymeti 1-den kicik ola bilmez!"
              SellPrice mağazanın satış qiymətidir. Satış qiyməti alış qiymətindən az ola bilməz. Xəta mesajı: "Satis qiymeti alis qiymetinden az ola bilmez!"
              OfferPrice kompaniya qiymətidir və alış qiymətindən ucuz ola bilər mağazanın öz seçimidir. Ancaq 1-dən kiçik ola bilməz. Xəta mesajı: "Kompaniya qiymeti 1-den kicik ola bilmez!"
              CreateDate, EditDate, DeleteDate uyğun zamanlarda set olunmalıdır. Belə null olacaq.
              CreateUser, EditUser, DeleteUser dəyərlərini hər hansısa bir rəqəm yazın fərz edin ki, User table'dakı bir Id'dir.

              Nəzərə alın ki, qiymətlər, Barcode və Id üçün encapsulation istifadə etsəniz daha yaxşı olar.
              Array'dan update, delete zamanı for ilə tapa bilərsiniz dəyərləri problem deyil Ram yüklənir falan deməyin ona fikir verməyəcəm.
             */

            Laptop laptop = new Laptop();
            laptop.Brand = "Asus";
            laptop.Model = "TUF FX705GM";
            laptop.CPU = "i9";
            laptop.Ram = "16";
            laptop.GraphicCard = "AMG 6gb";
            laptop.BuyPrice = 3600M;
            laptop.SellPrice = 4500M;
            laptop.OfferPrice = 4000M;
            laptop.Barcode = "123456789";
            VirtualDatabase.NewItem(laptop);

            Laptop laptop1 = new Laptop();
            laptop1.Brand = "Asus";
            laptop1.Model = "TUF FX705GM";
            laptop1.CPU = "i9";
            laptop1.Ram = "16";
            laptop1.GraphicCard = "AMG 6gb";
            laptop1.BuyPrice = 3600M;
            laptop1.SellPrice = 4500M;
            laptop1.OfferPrice = 4000M;
            laptop1.Barcode = "123456789"; //xeta cixmalidir
            VirtualDatabase.NewItem(laptop1);

            laptop.Model = "Rog";
            VirtualDatabase.UpdateItem(laptop);
            VirtualDatabase.DeleteItem(laptop);
            VirtualDatabase.DeleteItem(laptop1);


            Laptop laptop2 = new Laptop();
            laptop2.Brand = "Asus";
            laptop2.Model = "TUF FX705GM";
            laptop2.CPU = "i9";
            laptop2.Ram = "16";
            laptop2.GraphicCard = "AMG 6gb";
            laptop2.BuyPrice = 3600M;
            laptop2.SellPrice = 4500M;
            laptop2.OfferPrice = 4000M;
            laptop2.Barcode = "123456789"; //xeta cixmamalidir
            VirtualDatabase.NewItem(laptop);

            Tv tv1 = new Tv();
            Tv tv2 = new Tv();
            Tv tv3 = new Tv();

            //cem
            VirtualDatabase.NewItems(laptop, tv1, tv2, laptop1, tv3);
            VirtualDatabase.NewItems(laptop, tv1);
            VirtualDatabase.NewItems(tv2, tv1, laptop2);

            //tek
            VirtualDatabase.NewItem(tv3);
            VirtualDatabase.NewItem(laptop);
        }
    }
}
