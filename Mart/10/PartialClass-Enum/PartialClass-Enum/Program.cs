using PartialClass_Enum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class
            Book book = new Book();
            book.Id = 1;
            book.CreateDate = DateTime.Now;
            book.CreateUser = 100;
            book.Code = 123456789;
            book.Genre = "SomeGenre";
            book.Publisher = "SomePublisher";
            book.Cover = "Karton";
            book.Author = "SomeAuthor";
            book.Page = 365;
            book.Language = "ENG";

            book.Add(book);
            book.Update(book);
            book.Delete(1);

            book.MyMethod1();
            book.MyMethod4();
            book.MyMethod12();
            book.MyMethod16();
            book.MyMethod21();
            book.MyMethod24();



            Car car = new Car();
            car.Id = 5;
            car.CreateDate = DateTime.Now;
            car.CreateUser = 100;
            car.Brand = "Mercedes";
            car.Model = "GL500";
            car.Year = 2021;
            car.SeatCount = 6;
            car.SeatMaterial = "Deri";
            car.DoorCount = 5;
            car.Engine = 5000;
            car.FuelType = "Benzin";
            car.Add(car);
            car.Update(car);
            car.Delete(1);

            car.MyMethod1();
            car.MyMethod4();
            car.MyMethod12();
            car.MyMethod16();
            car.MyMethod21();
            car.MyMethod24();
            #endregion



            #region Enum
            Person person = new Person();
            person.Name = "Orkhan";
            person.Surname = "Farajov";
            person.Gender = GenderEnum.Male;
            person.GenderInteger = (int)GenderEnum.Male;

            if(person.Gender == GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person isn't Male");


            if (person.Gender.Equals(GenderEnum.Male))
                Console.WriteLine("Gender is equal to Male");
            else
                Console.WriteLine("Gender isn't equal to Male");

            if (person.GenderInteger == (int)GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person isn't Male");



            Car2 mercedes = new Car2();
            mercedes.Model = "Mercedes";
            mercedes.Color = ColorEnum.White;

            Car2 bmw = new Car2();
            bmw.Model = "BMW";
            bmw.Color = ColorEnum.Green;
            #endregion
        }
    }
}
