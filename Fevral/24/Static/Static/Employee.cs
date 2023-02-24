using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Employee
    {
        public static string domain;
        public string Name { get; set; }
        public string Surname { get; set; }

        private string _email;

        public string Email {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value.ToLower() + "@" + Employee.domain;
            }
        }

        public Employee()
        {
            Console.WriteLine("This method will run on every instance");
        }

        static Employee()
        {
            domain = "google.com";
        }
    }
}
