using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Student
    {
        private static ArrayList Database;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public void Test()
        {
            Console.WriteLine("Bu methodu istifade etmek ucun Student class'inin instance'i yaradilmalidir.");
        }

        public static void Test1()
        {
            Console.WriteLine("Bu methodu istifade etmek ucun Student class'inin instance'i YARADILMAMALIDIR!");
        }
    }
}
