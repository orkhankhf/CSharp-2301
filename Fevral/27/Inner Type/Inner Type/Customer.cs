using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_Type
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        #region Inner Type required fields
        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;
        #endregion

        public Customer()
        {
            Contacts = new Contact[100];
            Addresses = new Address[100];
            Orders = new Order[100];
        }

        public void ShowAddresses()
        {
            foreach (var item in Addresses)
            {
                if(item != null)
                {
                    Console.WriteLine("ID: " + item.Id);
                    Console.WriteLine("Street: " + item.Street);
                    Console.WriteLine("City: " + item.City.Name);
                    Console.WriteLine("Country: " + item.City.Country.Name);

                    if (item.EditDate == null)
                        Console.WriteLine("Edit Date: Data is not edited");
                    else
                        Console.WriteLine("Edit Date: " + item.EditDate);
                }
            }
        }

        public void ShowContacts()
        {
            foreach (var item in Contacts)
            {
                if (item != null)
                {
                    Console.WriteLine("ID: " + item.Id);
                    Console.WriteLine("PhoneNumber: " + item.PhoneNumber);
                    Console.WriteLine("Email: " + item.Email);

                    if (item.EditDate == null)
                        Console.WriteLine("Edit Date: Data is not edited");
                    else
                        Console.WriteLine("Edit Date: " + item.EditDate);
                }
            }
        }

        public void ShowOrders()
        {
            foreach (var item in Orders)
            {
                if (item != null)
                {
                    Console.WriteLine("ID: " + item.Id);
                    Console.WriteLine("OrderDetails: " + item.OrderDetails);
                    Console.WriteLine("Shipping Address Details:");
                    Console.WriteLine(item.ShippingAddress.Id);
                    Console.WriteLine(item.ShippingAddress.City.Country.Name);
                    Console.WriteLine(item.ShippingAddress.City.Name);
                    Console.WriteLine(item.ShippingAddress.Street);
                    Console.WriteLine(item.ShippingAddress.Building);
                    Console.WriteLine(item.ShippingAddress.No);

                    if (item.EditDate == null)
                        Console.WriteLine("Edit Date: Data is not edited");
                    else
                        Console.WriteLine("Edit Date: " + item.EditDate);
                }
            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine("Customer Info");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("------------------------------------------------");


            Console.WriteLine("Address Info");
            ShowAddresses();
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Contact Info");
            ShowContacts();
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Order Info");
            ShowOrders();
        }
    }
}
