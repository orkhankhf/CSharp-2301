using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is NOT Generic Class
            Customer customer = new Customer();
            
            GenericCustomer<string> gCustomer = new GenericCustomer<string>();
            gCustomer.Id = 5;
            gCustomer.Name = "Orkhan";
            gCustomer.Surname = "Farajov";
            gCustomer.DateOfBirth = new DateTime(1995, 12, 24);
            gCustomer.DocumentNo = "123456";
            gCustomer.DocumentSerial = "AA";
            gCustomer.PlaceOfBirth = "Baku";


            MultipleGenericClass<string, int, DateTime> multiGeneric = new MultipleGenericClass<string, int, DateTime>();
            multiGeneric.Id = 1;
            multiGeneric.Name = "Orkhan";
            multiGeneric.Surname = "Farajov";
            multiGeneric.DateOfBirth = new DateTime(1995, 12, 24);

            string name = multiGeneric.GetName();

            MultipleGenericClass<char, int, DateTime> multiGeneric1 = new MultipleGenericClass<char, int, DateTime>();
            multiGeneric1.Id = 1;
            multiGeneric1.Name = 'A';
            multiGeneric1.Surname = 'B';
            multiGeneric1.DateOfBirth = new DateTime(1995, 12, 24);
            #endregion


            #region What is Generic Class
            /*
             Database    |    App
             MsSQL       |  C#/.NET
             */

            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();
            List<Customer> customers = customerRepository.Get();

            GenericRepository<Item> itemRepository = new GenericRepository<Item>();
            List<Item> items = itemRepository.Get();


            Customer cust = new Customer();
            Item item = new Item();

            customerRepository.Add(cust);
            itemRepository.Add(item);

            //GenericRepository<int> intRepository = new GenericRepository<int>();
            #endregion
        }
    }
}
