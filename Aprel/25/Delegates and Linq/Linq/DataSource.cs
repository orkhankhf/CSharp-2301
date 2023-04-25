using Linq.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DataSource
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public DataSource()
        {
            Random rand = new Random();

            for (int i = 1; i <= 100000; i++)
            {
                Customer customer = new Customer()
                {
                    Id = i,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Age = rand.Next(1, 80),
                    DateOfBirth = FakeData.DateTimeData.GetDatetime(new DateTime(1950, 01, 01), new DateTime(2004, 01, 01)),
                    Gender = (rand.Next(1, 100) % 2 == 0) ? GenderEnum.Male : GenderEnum.Female,
                    Country = FakeData.PlaceData.GetCountry(),
                    City = FakeData.PlaceData.GetCity(),
                    PostCode = FakeData.PlaceData.GetPostCode(),
                    Address = FakeData.PlaceData.GetAddress(),
                    Phone = FakeData.PhoneNumberData.GetPhoneNumber(),
                    Email = FakeData.NetworkData.GetEmail()
                };
                Customers.Add(customer);
            }
        }

        #region Without Linq
        public List<Customer> GetCustomersByFirstLetterOfName(char letter)
        {
            var output = new List<Customer>();

            for (int i = 0; i < Customers.Count; i++)
            {
                if (char.ToLower(Customers[i].Name[0]) == char.ToLower(letter))
                    output.Add(Customers[i]);
            }

            return output;
        }

        public List<Customer> GetCustomersByAge(int min, int max)
        {
            var output = new List<Customer>();

            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].Age >= min && Customers[i].Age <= max)
                    output.Add(Customers[i]);
            }

            return output;
        }
        #endregion

        #region With Linq
        public List<Customer> GetCustomersByFirstLetterOfNameLinq(char letter)
        {
            return Customers.Where(m => m.Name.StartsWith(letter.ToString())).ToList();
        }

        public List<Customer> GetCustomersByAgeLinq(int min, int max)
        {
            return Customers.Where(m => m.Age >= min && m.Age <= max).ToList();
        }
        #endregion
    }
}
