using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    public class Student
    {
        /*
         Method necə yazılır?
         [access modifier] [return type] [method name] ( parameters ){
               methodun body hissəsi
         }

         Access Modifiers:
         1. Public
         Bir methodu public təyin etdiyimiz zaman biz əslində deyirik ki, class'a əli çatan hər yerdə bu methoddan istifadə etmək icazəsi veririk.

         2. Private
         Əgər methodumuzu private təyin etsək o zaman bu methoda yalnız və yalnız təyin etdiyimiz class daxilindən əlimiz çatır. Yəni class'ın
         içində private method təyin edəndə, bu method'u ancaq həmin class'ın içindən çağırmaq olur. Class'ları private təyin edə bilmirik.
         
         3. Protected
         4. Internal
         4. Internal Protected
         */

        public void HelloStudent()
        {
            Console.WriteLine("Salam telebeler.");
        }

        private void ShowStudentInfo(string name, string surname)
        {
            Console.WriteLine("Telebe melumati: " + name + " " + surname);
        }

        public void ShowOrkhansInformation()
        {
            ShowStudentInfo("Orkhan", "Farajov");
        }
    }
}
