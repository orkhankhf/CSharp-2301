using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Part_3
{
    public sealed class Teacher : Person
    {
        public string Branch { get; set; }
        public string Level { get; set; }
        public string IsProfessor { get; set; }

        public Teacher()
        {
            Console.WriteLine("CTOR: Teacher class");
        }
    }
}
