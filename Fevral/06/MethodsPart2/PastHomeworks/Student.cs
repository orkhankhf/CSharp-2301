using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomeworks
{
    public class Student
    {
        public void CalcAverage(string name, string surname, decimal p1, decimal p2, decimal p3 = 45)
        {
            Console.WriteLine("Telebe melumatlari: ");
            Console.WriteLine("Ad Soyad  : {0} {1}", name, surname);

            //(birinci yazı qaydası)
            decimal average = CalcAverage(p1, p2, p3);
            RateAverage(average);

            //(ikinci yazı qaydası)
            RateAverage(CalcAverage(p1, p2, p3));
        }

        void RateAverage(decimal avrg)
        {
            if (avrg < 45)
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kesildiniz!", avrg);
            else
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kecdiniz.", avrg);
        }

        private decimal CalcAverage(decimal p1, decimal p2, decimal p3)
        {
            ////(birinci yazı qaydası)
            //decimal avrg = (p1 + p2 + p3) / 3;
            //return avrg;

            //(ikinci yazı qaydası)
            return (p1 + p2 + p3) / 3;
        }
    }
}
