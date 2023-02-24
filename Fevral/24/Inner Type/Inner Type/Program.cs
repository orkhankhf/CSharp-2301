using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DocumentNo = 555222,
                BirthDate = DateTime.Now,
                CreateDate = DateTime.Now,
                EditDate = null
            };

            Country country = new Country()
            {
                Id = 1,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now,
            };

            City city = new City()
            {
                Id = 1,
                Name = "Baku",
                Country = country,
                CreateDate = DateTime.Now,
            };

            Order laptopOrder = new Order()
            {
                Id = 1,
                OrderDetails = "Asus Tuf, 3500AZN",
                CreateDate = DateTime.Now
            };

            customer.Addresses[0] = new Address()
            {
                Id = 1,
                No = 15,
                Building = "MyBuilding",
                Street = "HomeStreet",
                Distinct = "Narimanov",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Addresses[1] = new Address()
            {
                Id = 1,
                No = 15,
                Building = "Residance",
                Street = "WorkStreet",
                Distinct = "Yasamal",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 1,
                Email = "orkhankhf@gmail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Contacts[1] = new Contact()
            {
                Id = 1,
                Email = "orkhankhf@gmail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Contacts[2] = new Contact()
            {
                Id = 1,
                Email = "orkhankhf@gmail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id = 2,
                OrderDetails = "Samsung Galaxsy s9+, 600 AZN",
                ShippingAddress = customer.Addresses[1],
                CreateDate = DateTime.Now
            };

            customer.Orders[1] = laptopOrder;
        }
    }
}
