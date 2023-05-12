using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_and_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             [
                {
                    "Id":"1",
                    "Name":"Orkhan",
                    "Surname":"Farajov",
                    "Age":"28",
                    "Phone":"055-581-08-72"
                }
             ]
             */

            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 1000; i++)
            {
                Customer customer = new Customer();
                customer.Id = Guid.NewGuid();
                customer.Name = FakeData.NameData.GetFirstName();
                customer.Surname = FakeData.NameData.GetSurname();
                customer.Email = $"{customer.Name}.{customer.Surname}@{FakeData.NetworkData.GetDomain()}";
                customer.PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber();
                customer.Country = FakeData.PlaceData.GetCountry();

                customers.Add(customer);
            }

            Console.WriteLine(@"Məlumatlarınız C:\Json\Customers.json faylına yazılacaq.");

            if (!Directory.Exists("C:\\Json"))
            {
                Directory.CreateDirectory("C:\\Json");
            }

            //Convert List<Customer> data to json string
            string jsonCustomers = JsonConvert.SerializeObject(customers);

            //Save json string to a json file in path
            File.WriteAllText(@"C:\\Json\\Customers.json", jsonCustomers); 



            //read json data as string from file in path
            string readJsonData = File.ReadAllText(@"C:\\Json\\Customers.json");

            //deserialize string json data to object
            List<XObject> data = JsonConvert.DeserializeObject<List<XObject>>(readJsonData);

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Surname);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.PhoneNumber);
            //    Console.WriteLine(item.Country);
            //    Console.WriteLine("-------------------------------------");
            //}


            //--------------------------------------------------------------------------------------------------------


            string readPersonData = File.ReadAllText("C:\\Json\\Persons.json");

            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(readPersonData);
             


            string diffPropData = File.ReadAllText("C:\\Json\\PersonsDifferentName.json");

            List<Person> diffPersonData = JsonConvert.DeserializeObject<List<Person>>(diffPropData);

            foreach (var item in diffPersonData)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.PhoneNumber);
                Console.WriteLine(item.Country);
            }


            List<PersonWithAttribute> diffPersonDataWithAttr = JsonConvert.DeserializeObject<List<PersonWithAttribute>>(diffPropData);

            foreach (var item in diffPersonDataWithAttr)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.PhoneNumber);
                Console.WriteLine(item.Country);
            }

        }
    }
}
