using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First C# Code
            //Console.Write("Hello ");
            //Console.Write("World");

            //Console.WriteLine("Hello World!");
            //Console.Write("ByBy ");
            //Console.ReadLine();

            /*
             System - namespace adı
             Console - System namespace'inin içindəki bir class adı
             Write - Console class'ının içindəki bir method adı
             */
            #endregion



            #region Task in Lesson 1
            //"Salam xos gelmisiniz!"
            //"Adinizi daxil edin:"
            //Console.WriteLine("Salam xos gelmisiniz!");
            //Console.WriteLine("Adinizi daxil edin: ");
            #endregion



            #region Read user data
            //var read = Console.Read();
            //var readKey = Console.ReadKey();
            //var readLine = Console.ReadLine();

            //Console.WriteLine("Xos gelmisiniz!");
            //Console.WriteLine("Adiniz nedir?");
            //var nameOfUser = Console.ReadLine();

            //var welcomeMsg = "Xos gelmisiniz!";
            //Console.WriteLine(welcomeMsg);

            //var whatIsYourName = "Adiniz nedir?";
            //Console.WriteLine(whatIsYourName);
            //Console.ReadLine();
            #endregion



            #region Breakpoint
            //Console.WriteLine("Top 1");
            //Console.WriteLine("Top 2");
            //Console.WriteLine("Top 3");
            //Console.WriteLine("Top 4");
            //Console.WriteLine("Top 5");
            //Console.WriteLine("Top 6");
            //Console.WriteLine("Top 7");
            //Console.WriteLine("Top 8");
            //Console.WriteLine("Top 9");
            //Console.WriteLine("Top 10");
            //Console.ReadLine();

            /*
             Breakpoint atdıqdan sonra, yəni debug etdiyiniz zaman:
             - F10'a basdıqda olduğunuz sətirdən sonrakı ilk kod olan sətrə aparır.
             - F5'ə basdıqdan sonra olduğunuz sətirdən sonrakı bütün kodları oxuyub icra edir.
             - Kodu bir və ya bir neçə statement geriyə qaytarmaq üçün sarı oxu yuxarı aşağı çəkə bilirsiniz.
             */
            #endregion


            #region Task in Lesson 2
            /*
             red - qirmizi
             car - avtomobil
             expensive - bahali
             phone - telefon

             qirmizi avtomobil
             bahali telefon
             */

            //var red = "qirmizi";
            //var car = "avtomobil";
            //var expensive = "bahali";
            //var phone = "telefon";

            //Console.Write(red);
            //Console.Write(car);
            //Console.WriteLine();
            //Console.Write(expensive);
            //Console.Write(phone);

            //Console.WriteLine(red + " " + car);
            //Console.WriteLine(expensive + " " + phone);
            #endregion



            #region Comment and Region
            //Bu bir tek setirlik comment'dir

            /* Tek setir */

            /*
             Bu bir
             multi-line
             comment
             setiridir.
             */

            #region Registration
            Console.WriteLine("Registration codes...");
            #endregion

            #region Login
            Console.WriteLine("Login codes...");
            #endregion

            #region Profile Section
            Console.WriteLine("Profile codes...");
            #endregion
            #endregion



            #region Variables
            //typeOfVariable nameOfVariable = valueOfVariable
            string person = "Orkhan Farajov";

            Console.WriteLine(person);


            string anotherPerson;
            anotherPerson = "Orkhan Farajov";
            Console.WriteLine(anotherPerson);

            string name = "Orkhan";
            Console.WriteLine(name);

            name = "Elcin";
            Console.WriteLine(name);

            name = "Ferhad";
            Console.WriteLine(name);
            #endregion


            #region Naming Convention
            /*
             Nümunə dəyişən adları:
             _nameSurname (private üçün. gələcəkdə izah edəcəm)
             nameSurname
             anotherPerson
             nameSurname1
             anotherFatherName
             redCarName
             streetNumber
             city
             countryCode
             */
            #endregion


            #region What is Ram and how does it work?
            /*
             1. S RAM (Static Random Access Memory)
             2. D RAM (Dynamic Random Access Memory)
             3. SD RAM (Synchronous Dynamic Random Access Memory)
             4. DDR SD RAM (Double Data Rate Synchronous Dynamic Random Access Memory)
             5. GDDR SD RAM (Graphics Double Data Rate Synchronous Dynamic Random Access Memory)
             */
            #endregion

            Console.ReadLine();
        }
    }
}
