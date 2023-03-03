using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    public class Teacher : Person
    {
        public DateTime DateOfStartWorking { get; set; }
        public DateTime? DateOfEndWorking { get; set; }
        public int RestDays { get; set; }
        public string Branch { get; set; }
        public string Level { get; set; }
    }
}
