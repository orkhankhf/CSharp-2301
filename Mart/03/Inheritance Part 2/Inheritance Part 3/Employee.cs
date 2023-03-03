using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Part_3
{
    public class Employee : Person
    {
        public string Sector { get; set; }
        public int WorkType { get; set; } //1=PartTime | 2=Fulltime
        public decimal Salary { get; set; }
    }
}
