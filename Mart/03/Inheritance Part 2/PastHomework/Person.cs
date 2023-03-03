using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    public class Person : BaseSettings
    {
        public string ReferanceNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Gender { get; set; } //1: kisi, 2: qadin, 3: -
    }
}
