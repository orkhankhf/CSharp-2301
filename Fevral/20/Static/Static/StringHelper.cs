using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class StringHelper
    {
        public static string CheckFullname(string name, string surname)
        {
            string fullname;
            if((name+surname).Length > 20)
            {
                fullname = name[0] + ". " + surname;
                return fullname;
            }

            return name + " " + surname;
        }
    }
}
