using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart6
{
    public class VirtualDatabase
    {
        public List<Customer> Customers = new List<Customer>();

        public List<Customer> GetCustomers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Customer customer = new Customer();

                customer.Id = i + 1;
                customer.Name = FakeData.NameData.GetFirstName();
                customer.Surname = FakeData.NameData.GetSurname();
                customer.Fullname = $"{customer.Name} {customer.Surname}";
                customer.Email = FakeData.NetworkData.GetEmail(customer.Name, customer.Surname);
                customer.Phone = FakeData.PhoneNumberData.GetPhoneNumber();
                customer.Country = FakeData.PlaceData.GetCountry();
                customer.City = FakeData.PlaceData.GetCity();
                customer.Address = FakeData.PlaceData.GetAddress();

                Customers.Add(customer);
            }
            return Customers;
        }
    }
}
