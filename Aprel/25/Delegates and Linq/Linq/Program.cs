using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Enums;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq - Language Integrated Query
            #region Task in Lesson 1
            /*
             Task description:
                  Bir dənə Customer class'ı yaradın və Id, Name, Surname, Age property'ləri olsun. DataSource adında da bir class yaradın və Customers tipində
                  bir list əlavə edin. DataSource class'ının constructor'unda FakeData'ynan həmin Customers listinə 100000 dənə müştəri məlumatları əlavə edin.
                  Daha sonra bu DataSource class'ında 2 method'unuz olacaq. Birinci method parametr olaraq hərf alacaq və o hərflə adı başlayan adamları list
                  olaraq qaytaracaq. İkinci method isə, bir yaş aralığı alacaq və o yaş aralığında olan adamları qaytaracaq. Məsələn 18-25 yaş.
             */

            DataSource ds = new DataSource();
            //Without Linq
            var age18_25 = ds.GetCustomersByAge(18, 25);
            var nameStartsWithB = ds.GetCustomersByFirstLetterOfName('B');


            //With Linq
            var ageFilter = ds.GetCustomersByAge(18, 25);
            var nameFilter = ds.GetCustomersByFirstLetterOfName('B');
            #endregion

            #region Linq Queries
            /*
              ---- System.Linq ----
              ds.Customers.Where()
              ds.Customers.FirstOrDefault()
              ds.Customers.Max()

              ---- System.Collections.Generic ----
              ds.Customers.Add()
              ds.Customers.AddRange()
              ds.Customers.AddRange()
             */

            var maleCustomers = ds.Customers.Where(m => m.Gender == GenderEnum.Male);

            //Musteri sayisini almaq
            var countOfCustomers = ds.Customers.Count;

            //Olkesi almaniya olmayanlar
            var notFromGermany = ds.Customers.Where(m => m.Country != "Germany");
            
            //Olkesi turkiye olanlar
            var fromTurkey = ds.Customers.Where(m => m.Country == "Turkey");

            //Olkesi almaniya olmayan ve yasi 20-den boyuk olanlar
            var notFromGermanyAndOver20 = ds.Customers.Where(m => m.Country != "Germany" && m.Age > 20);
            
            //Adi t herfiyle baslayan ve soyadi n ile bitenler
            var startsT_endsN = ds.Customers.Where(m =>
                m.Name.ToLower().StartsWith("t") &&
                m.Surname.ToLower().EndsWith("n"));

            var notFromGermanyArr = notFromGermany.ToArray();
            var fromTurkeyList = fromTurkey.ToList();


            //IEnumerable, lazy loading'i desteklemir
            //IQueryable, lazy loading'i destekleyir

            //(IEnumerable System.Collections.Generic)
            //(IQueryable System.Linq)
            IEnumerable<Customer> badQuery = ds.Customers.Where(m => m.Name.StartsWith("N"));
            badQuery = badQuery.Take<Customer>(1);

            IQueryable<Customer> goodQuery = ds.Customers.AsQueryable().Where(m => m.Name.StartsWith("N"));
            goodQuery = goodQuery.Take<Customer>(1);

            //bad: select * from Customers where Name like 'N%';
            //good: select top 1 * from Customers where Name like 'N%';

            var methodSyntax = ds.Customers.Where(a =>
                                a.Name.StartsWith("A") &&
                                a.Age >= 45 &&
                                a.Age <= 55)
                                .Count();

            var querySyntax = (from a in ds.Customers
                               where
                                a.Name.StartsWith("A") &&
                                a.Age >= 45 &&
                                a.Age <= 55
                               select a)
                               .Count();
            #endregion



            #region Practise Linq
            IEnumerable<Customer> query1 = ds.Customers.Where(m => m.Country.ToLower().Contains("b") && m.City.ToLower().StartsWith("c"));
            
            IEnumerable<Customer> query2 = ds.Customers.Where(m => m.City.ToLower().StartsWith("a") && m.City.ToLower().EndsWith("e"));

            List<Customer> customers = ds.Customers.Where(m => m.Name == "Jack").ToList();

            Customer customer = ds.Customers.FirstOrDefault(m => m.Phone == "0555555555");

            var query3 = ds.Customers.Where(m => m.DateOfBirth.Year == 1990).ToList();

            var query4 = ds.Customers.Where(m => m.DateOfBirth.Month == 12).Take(2).ToList();
            #endregion


            #region Func Delegate
            var q1 = ds.Customers.Where(m => m.Email.ToLower().StartsWith("a"));
            //------------
            bool StartsWithA(Customer m)
            {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            }

            Func<Customer, bool> startsWithA_delegete = new Func<Customer, bool>(StartsWithA);

            var q2 = ds.Customers.Where(startsWithA_delegete);
            //------------
            var q3 = ds.Customers.Where(new Func<Customer, bool>(StartsWithA));
            //------------
            var q4 = ds.Customers.Where(delegate (Customer m) {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            });
            //------------
            var q5 = ds.Customers.Where((Customer m) => {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            });
            //------------
            var q6 = ds.Customers.Where((m) => {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            });

            var q7 = ds.Customers.Where(m => m.Email[0] == 'A');
            #endregion


            #region Predicate Delegate
            var p1 = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));

            //Long version
            bool predicateDelegateMethod(Customer m)
            {
                if (m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12))
                    return true;
                else
                    return false;
            }

            Predicate<Customer> predicate = new Predicate<Customer>(predicateDelegateMethod);

            var delegate1 = ds.Customers.FindAll(predicate);

            //Short versions

            var delegate2 = ds.Customers.FindAll(new Predicate<Customer>(predicateDelegateMethod));

            var delegate3 = ds.Customers.FindAll(delegate (Customer m) { return m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12); });

            var delegate4 = ds.Customers.FindAll((Customer m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));

            var delegate5 = ds.Customers.FindAll((m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));

            var delegateLambda = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1990, 12, 12));
            #endregion

            #region Action Delegate
            foreach (var item in ds.Customers)
            {
                Console.WriteLine($"{item.Name} {item.Surname} is {item.Age} years old.");
            }

            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            //Long version
            void ShowCustomerInfo(Customer m)
            {
                Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old.");
            }

            Action<Customer> action = new Action<Customer>(ShowCustomerInfo);

            ds.Customers.ForEach(action);

            //Short version
            ds.Customers.ForEach(new Action<Customer>(ShowCustomerInfo));

            ds.Customers.ForEach(delegate (Customer m) { Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."); });

            ds.Customers.ForEach((Customer m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            ds.Customers.ForEach((m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));
            #endregion
        }
    }
}
