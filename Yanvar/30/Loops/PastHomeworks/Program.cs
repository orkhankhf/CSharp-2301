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
             Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. İkincidə 50 daxil etdi onu da
                       b dəyişənində saxlayın. Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.
             */

            //int a, b, c;

            //Console.WriteLine("Birinci rəqəmi daxil edin : ");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci rəqəmi daxil edin : ");
            //b = int.Parse(Console.ReadLine());

            //c = a;
            //a = b;
            //b = c;


            /*
             Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu
                         çıxma, vurma və bölmə üçün də edin.
             */
            //int num1, num2, num3;

            //Console.Write("İlk rəqəmi daxil edin: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci rəqəmi daxil edin: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Üçüncü rəqəmi daxil edin: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //int result = num1 * num2 * num3;
            //Console.WriteLine("Nəticə: " + num1 + " x " + num2 + " x " + num3 + " = " + result);


            /*
             Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün də edin. Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil
                         edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.
             */

            //int num4 = 0;
            //Console.WriteLine("10 deyer daxil edin: ");
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4 += Convert.ToInt32(Console.ReadLine());
            //num4++;
            //Console.WriteLine("Netice: " + num4);



            /*
             Homework 4: İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə çevirəcəksiz. bool, string, short, long, int, char, datetime.
             */

            //Console.Write("Bool deyerini daxil edin");
            //bool toBool = Convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine("String deyerini daxil edin");
            //string toString = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("short deyerini daxil edin");
            //short toShort = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Long deyerini daxil edin");
            //long toLong = Convert.ToInt64(Console.ReadLine());

            //Console.WriteLine("int deyerini daxil edin");
            //int toInt = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Char deyerini daxil edin");
            //char toChar = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Datetime daxil edin");
            //DateTime toTime = Convert.ToDateTime(Console.ReadLine());



            //------------------------------------------------------------------------------------------------------------------------------------------------------
            
            //Condition Statements Homeworks

            /*
             Homework 1:
             Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
             Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
             */

            //const string username = "admin";
            //const string password = "admin";

            //Console.WriteLine("Istifadeci adinizi daxil edin: ");
            //string u = Console.ReadLine();

            //Console.WriteLine("Sifrenizi daxil edin: ");
            //string p = Console.ReadLine();

            //if (u == username && p == password)
            //{
            //    Console.WriteLine("Sisteme daxil olundu.");
            //}
            //else
            //{
            //    Console.WriteLine("Istifadeci adinizi daxil edin: ");
            //    u = Console.ReadLine();
            //    Console.WriteLine("Sifrenizi adini daxil edin: ");
            //    p = Console.ReadLine();

            //    if (u == username && p == password)
            //    {
            //        Console.WriteLine("Sisteme daxil olundu.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Istifadeci adinizi daxil edin: ");
            //        u = Console.ReadLine();
            //        Console.WriteLine("Sifrenizi adini daxil edin: ");
            //        p = Console.ReadLine();

            //        if (u == username && p == password)
            //        {
            //            Console.WriteLine("Sisteme daxil olundu.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hesab bloklandi!");
            //        }
            //    }
            //}



            /*
             Homework 2:
             Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
             və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
             istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
             */

            string m = "mainMenu";
            decimal a = 0, b = 0;

            switch (m)
            {
                case "mainMenu":
                    Console.Clear();
                    Console.WriteLine("A deyeri daxil edin: ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("B deyeri daxil edin: ");
                    b = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Etmek istediyiniz emeliyyati secin: ");
                    Console.WriteLine("1. Toplama");
                    Console.WriteLine("2. Çıxma");
                    Console.WriteLine("3. Vurma");
                    Console.WriteLine("4. Bölme");
                    short choise = Convert.ToInt16(Console.ReadLine());
                    if (choise == 1)
                        goto case "toplama";
                    else if (choise == 2)
                        goto case "cixma";
                    else if (choise == 3)
                        goto case "vurma";
                    else if (choise == 4)
                        goto case "bolme";
                    else
                        Console.WriteLine("Yanlis emeliyyat secdiniz!");
                    goto case "mainMenu";

                case "toplama":
                    Console.WriteLine("Netice: " + (a + b));
                    goto case "mainMenu";
                case "cixma":
                    Console.WriteLine("Netice: " + (a - b));
                    goto case "mainMenu";
                case "vurma":
                    Console.WriteLine("Netice: " + (a * b));
                    goto case "mainMenu";
                case "bolme":
                    Console.WriteLine("Netice: " + (a / b));
                    goto case "mainMenu";
            }
        }
    }
}
