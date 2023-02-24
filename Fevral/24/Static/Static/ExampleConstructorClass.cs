using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class ExampleConstructorClass
    {
        //Static class içərisində, standart constructordan istifadə edə bilmərik
        //public ExampleConstructorClass()
        //{

        //}

        static ExampleConstructorClass()
        {
            Console.WriteLine("ctor...");
        }

        public static void ShowPersonInfo()
        {
            Console.WriteLine("Name: Orkhan");
            Console.WriteLine("Surname: Farajov");
            Console.WriteLine("Age: 28");
        }
    }
}
