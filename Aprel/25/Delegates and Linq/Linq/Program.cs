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
        }
    }
}
