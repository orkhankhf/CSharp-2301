using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Part_3
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        public Person()
        {
            Console.WriteLine("CTOR: Person class");
        }

        #region Protected access modifier
        protected void MyProtectedMethod()
        {
            Console.WriteLine("This method is protected...");
        }

        public void Test()
        {
            Console.WriteLine("Test called MyProtectedMethod");
            MyProtectedMethod();
        }
        #endregion
    }
}
