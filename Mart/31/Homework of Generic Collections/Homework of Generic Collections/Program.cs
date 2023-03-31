using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_of_Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Customer class'ının Id, Name, Surname, Age property'ləri olsun. Birdə əlavə olaraq Address Class'ı yaradıb onu da
             inner type olaraq Customer'ə property kimi əlavə edin. Address'in bu property'ləri olacaq: Id, No, Building, Street,
             City, Country. City və Country'ni Address'in içində string olaraq verin əlavə Class'a çıxarmağa ehtiyyac yoxdur.
             2-3 dənə Customer və onların Address'lərini əlavə edib sonra Customer tipində bir listə yığın. Sizdən istədiyim odur
             ki, Foreach ilə (customers.Foreach()) aşağıdakı kimi dataları yazdırasınız:
                ID: 1
                Name: Cavid
                Surname: Cavidov
                Age: 20
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country

                ID: 2
                Name: Hasan
                Surname: Hasanov
                Age: 32
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country
             */

            List<Customer> customers = new List<Customer>();

            Customer customer1 = new Customer() {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Age = 29,
                Address = new Address()
                {
                    Id = 100,
                    No = 10,
                    Building = "Some Building",
                    Street = "Some Street",
                    City = "Some City",
                    Country = "Some Country"
                }
            };

            Address addr = new Address()
            {
                Id = 101,
                No = 11,
                Building = "Some Building 1",
                Street = "Some Street 1",
                City = "Some City 1",
                Country = "Some Country 1"
            };

            Customer customer2 = new Customer()
            {
                Id = 1,
                Name = "Valeh",
                Surname = "Suleymanov",
                Age = 40,
                Address = addr
            };

            customers.Add(customer1);
            customers.Add(customer2);

            customers.ForEach(item =>
                Console.WriteLine(
                    "ID: {0}          \r\n" +
                    "Name: {1}        \r\n" +
                    "Surname: {2}     \r\n" +
                    "Age: {3}         \r\n" +
                    "Address Info:    \r\n" +
                    "ID: {4}          \r\n" +
                    "No: {5}          \r\n" +
                    "Building: {6}    \r\n" +
                    "Street: {7}      \r\n" +
                    "City: {8}        \r\n" +
                    "Country: {9}     \r\n",
                    item.Id,
                    item.Name,
                    item.Surname,
                    item.Age,
                    item.Address.Id,
                    item.Address.No,
                    item.Address.Building,
                    item.Address.Street,
                    item.Address.City,
                    item.Address.Country
                )
            );
            Console.ReadLine();
        }
    }
}
