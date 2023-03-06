using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            //var tostring = customer.ToString();
            //Console.WriteLine(tostring);

            customer.Name = "Orkhan";
            customer.Surname = "Farajov";
            var tostring = customer.ToString();

            Customer customerCahid = new Customer();
            customerCahid.Name = "Cahid";
            customerCahid.Surname = "Memmedov";
            var tostringCahid = customerCahid.ToString();
            Console.WriteLine(tostring);


            Item item = new Item();
            item.ShowText("ShowText called from Item");

            BaseClass bc = new BaseClass();
            bc.ShowText("ShowText called from BaseClass");

            item.ShowText("Hi!");
        }
    }
}
