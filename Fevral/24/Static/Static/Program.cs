using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static class
            //Helper helper = new Helper(); //(error)
            Helper.SayHi();
            
            Employee emp = new Employee();
            emp.Name = "Orkhan";
            emp.Surname = "Farajov";
            emp.Email = "orkhan";

            Employee emp2 = new Employee();
            emp2.Name = "Fuad";
            emp2.Surname = "Mustafayev";
            emp2.Email = "fuad";

            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
            ExampleConstructorClass.ShowPersonInfo();
            #endregion
        }
    }
}
