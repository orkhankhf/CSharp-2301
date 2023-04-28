using HomeworkSolutions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             public delegate void RunAnyMethod();

             public static void Add(){
                 Console.WriteLine("Add method");
             }

             public static void Edit(){
                 Console.WriteLine("Edit method");
             }

             public static void Delete(){
                 Console.WriteLine("Delete method");
             }

             Yuxarıda 1 delegate'iniz var və 3 dənə də standart adi method. Elə etməlisiniz ki, məsələn myDelegate adında bir dəyişəniniz olsun və myDelegate dəyişənini
             method kimi istifadə edə biləsiniz. Yəni myDelegate() yazanda bir method işləmiş olsun. Bu qayda da sadəcə 1 dəyişən sayəsində Add, Edit, Delete methodlarını
             işlətməlisiz. Bunu etmək üçün biraz araşdırmalı olacaqsız.
             */

            RunAnyMethod delegateMethod = new RunAnyMethod(Add);
            delegateMethod();

            delegateMethod = new RunAnyMethod(Edit);
            delegateMethod();

            delegateMethod = new RunAnyMethod(Delete);
            delegateMethod();


            /*
             Homework 2:
             Bir Car class'ınız olsun. (Property'ləri: Şəhər (satıldığı), Marka, Model, Buraxılış ili, Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı, Sürətlər Qutusunun tipi, Qiyməti).
             Bir list'in içinə bir neçə dənə Car əlavə edib nümunədən aşağıdakı sorğuları yazacaqsınız.
             Nümunə data:
             Şəhər: Bakı
             Marka: Lexus
             Model: GX460
             Buraxılış ili: 2021
             Rəngi: Black (Enum olacaq və 10-15 dənə rəng olsun Enum'da)
             Mühərrik Həcmi: 4500
             At Gücü: 296
             Kilometrajı: 15777
             Sürətlər Qutusunun tipi: Automatic (Enum olacaq. Dəyərləri də Automatic, Manual, Robot)
             Qiyməti: 200.000

             Aşağıdakı sorğuları yazın:
             1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
             2. Bakıda satılmayan, buraxılış ili 2015-ci il daxil olmaqla 2020-ci ilə qədər olan (2020 də daxildir buna)
             3. Kilometrajı 0 olan və Modelində "ml" sözü olan
             4. Sürətlər qutusu avtomatik olan və qiyməti 15.000-17.500 arasında olan
             5. Rəngi Red, Black olmayan, mühərrik həcmi 2000-4000 arasında olan, sürətlər qutusu Robot olmayan, buraxılış ili 2010-dan köhnə olmayan.
             6. Ya markası Lexus olub, qiyməti 30.000-ə qədər olan ya da markası Mercedes olub qiyməti 45.000-ə qədər olan.
             */

            List<Car> cars = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                    City = "Baku",
                    Brand = "Lexus",
                    Model = "GX460",
                    Year = 2021,
                    Color = ColorEnum.Black,
                    Engine = 4500,
                    HP = 296,
                    Km = 156.126m,
                    GearboxType = GearboxTypeEnum.Manual,
                    Price = 200.000m
                },
                new Car()
                {
                    Id = 1,
                    City = "Baku",
                    Brand = "Mercedes",
                    Model = "G65 AMG",
                    Year = 2022,
                    Color = ColorEnum.Black,
                    Engine = 6500,
                    HP = 412,
                    Km = 0,
                    GearboxType = GearboxTypeEnum.Automatic,
                    Price = 380.000m
                }
            };

            var q1 = cars.Where(m => m.Brand == "Mercedes" && m.Engine <= 4200 && m.City == "Baku");

            var q2 = cars.Where(m => m.City != "Baku" && (m.Year >= 2015 && m.Year <= 2020));

            var q3 = cars.FindAll(m => m.Km == 0 && m.Model.ToLower().Contains("ml"));

            var q4 = cars.FirstOrDefault(m => m.GearboxType == GearboxTypeEnum.Automatic && (m.Price > 15000 && m.Price < 17500));

            var q5 = cars.FirstOrDefault(m =>
                    (m.Color != ColorEnum.Red || m.Color != ColorEnum.Black) &&
                    (m.Engine > 2000 && m.Engine < 4000) &&
                    (m.GearboxType != GearboxTypeEnum.Robot) &&
                    (m.Year >= 2010));

            var q6 = cars.FindAll(m =>
                    (m.Brand == "Lexus" && m.Price <= 30000) ||
                    (m.Brand == "Mercedes" && m.Price <= 45000));


            /*
             Homework 3:
             Bir dənə int array'ında 1-1000 arası rəqəmləriniz olsun (for ilə edin).
             1. Array'dan cüt rəqəmləri sorğu ilə götürün.
             2. Arrayda 400-dən böyük, 550-yə bərabər və ya kiçik olan, tək rəqəmləri götürün.
             */

            int[] arr = new int[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i;
            }

            var arr_query1 = arr.Where(m => m % 2 == 0);

            var arr_query2 = arr.Where(m => m > 400 && m <= 550 && m % 2 != 0);

            /*
             Homework 4:
             Bir dənə String List'iniz olsun (names) və FakeData ilə 1000 dənə Name əlavə edin.
             Sonra həmin list'dən adı 5 simvol və ya daha uzun olan adları silin. Bunu etmək üçün Remove və ya RemoveAll method'larını araşdırın və sonra edin.
            */

            List<string> names = new List<string>();

            for (int i = 0; i < 1000; i++)
            {
                names.Add(FakeData.NameData.GetFirstName());
            }

            names.RemoveAll(m => m.Length >= 5);

            /*
             Homework 5:
             Name, Surname, Fullname property'ləri olan Person adlı bir class'ınız olsun. FakeData ilə Person tipində bir listə 1000 nəfər əlavə edin.
             Əlavə edəndə Name və Surname property'lərini set edin amma fullname boş qalsın. Artıq əlinizdə 1000 nəfərin Ad və Soyadı olan bir list hazır olduqdan
             sonra Linq istifadə edərək Ad və Soyad'dan Fullname'i set edin.
             */

            List<Person> persons = new List<Person>();

            for (int i = 0; i < 1000; i++)
            {
                persons.Add(new Person(FakeData.NameData.GetFirstName(), FakeData.NameData.GetSurname()));
            }

            persons.ForEach(m => m.Fullname = m.Name + " " + m.Surname);
        }

        public delegate void RunAnyMethod();

        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Edit method");
        }

        public static void Delete()
        {
            Console.WriteLine("Delete method");
        }
    }
}
