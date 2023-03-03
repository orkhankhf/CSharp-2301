using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Part_3
{
    public sealed class Student : Person
    {
        public string Degree { get; set; }
        public string ClassName { get; set; }
        public decimal Attendance { get; set; }

        public Student()
        {
            Console.WriteLine("CTOR: Student class");
            #region Protected access modifier
            MyProtectedMethod();
            #endregion
        }
    }
}
