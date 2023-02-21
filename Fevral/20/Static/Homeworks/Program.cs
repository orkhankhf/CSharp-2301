using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             Static constructor'un nə olduğunu və static ctor ilə standart ctor'un fərqlərini araşdırın.

             Homework 2:
             Customer adında bir class içində database kimi istifadə etmək üçün private static ArrayList olacaq. Bu Arraylist'in instance'ı
             static bir constructor daxilində yaradılacaq. Customer class'ında Id, Ad, Soyad, Email, Username və Password olacaq. Bir şeyi
             nəzərə alın ki, Username və Password həm field, həm də property, digərləri isə sadəcə property olacaq. Username get olan zaman
             field olan username return olacaq. Set olanda isə, value duplicate yoxlamasından keçəcək. Əgər artıq database'də (Arraylist)
             bu Username'də customer varsa, "Elave etmek istediyiniz username artiq sistemde movcuddur!" xətası çıxsın.

             Bu yoxlamanı bool tipində bir methodda edin. Bir başqa method'unuz isə, müştərini əlavə etmək üçün olmalıdır. Bu method
             Customer tipində parameter qəbul edəcək. Parametr obyektinin null, Username və Email'in isə həm null həm də boş olmamasını
             check etdikdən sonra, username'i yoxlayan method kimi bir method daha olacaq. Oda email adresinin duplicate olub olmamasını
             yoxlayacaq. Əgər email adresi varsa, "Elave etmek istediyiniz email artiq sistemde movcuddur!" xətası ekrana yazılacaq.

             Əgər yoxdursa müştəri database'ə əlavə edilib "Yeni musteri sisteme elave olundu!" mesajı ekrana yazdırılacaq.
             Birdə password encapsulation üçün həm field həm də property olacaq. Property'nin getter'ində field return olacaq, setter'ində
             isə password'un valid olub olmaması yoxlanılacaq. Bunun üçün bir method yazın hansı ki, şifrəni validate etsin. Şifrə minimum
             8 simvol, ən az 1 böyük hərf və 1 rəqəm olmalıdır. Deyilsə, "Sifre en az 8 simvoldan ibaret, icinde en az 1 boyuk herf ve 1
             reqem olmalidir." mesajı çıxsın. Customer məlumatlarını elə Main method'unun içində kod tərəfdə yazmaq kifayətdir. Console 
             ekranından userdən soruşmağa ehtiyyac yoxdur.
             */
        }
    }
}
