using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class Customer : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer()
        {
            Console.WriteLine("Customer constructor");
        }

        public override void ShowTime()
        {
            Console.WriteLine("Customer -> ShowTime: {0}", DateTime.Now);
        }
    }
}
