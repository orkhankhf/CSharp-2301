using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
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
        }
    }
}
