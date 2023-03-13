using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualDatabase virtualDb = new VirtualDatabase();
            virtualDb.Add(10);
            virtualDb.Add(20);

            #region Using simple Generic Collections
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Bir");

            //<T> : T tipi, .NET framework'unun içində olan və ya bizim yaratdığımız hər hansısa bir tip deməkdir.

            List<int> genericList = new List<int>();
            genericList.Add(5);
            genericList.Add(15);
            genericList.Add(20);
            //genericList.Add("");

            List<string> names = new List<string>();
            names.Add("Orkhan");
            names.Add("Musa");
            names.Add("Valeh");

            List<bool> booleanGC = new List<bool>();
            booleanGC.Add(true);
            booleanGC.Add(false);
            #endregion


            #region Using customer types with Generic Collections and Linq methods
            List<Student> students = new List<Student>();

            //1-ci yol
            students.Add(new Student()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Age = 28
            });

            //2-ci yol
            Student student = new Student()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Age = 28
            };
            students.Add(student);

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                                  students[i].Id,
                                  students[i].Name,
                                  students[i].Surname,
                                  students[i].Age);
            }

            foreach (var item in students)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                                  item.Id,
                                  item.Name,
                                  item.Surname,
                                  item.Age);
            }
            #endregion

            #region Task in Lesson 1
            //numbersToAdd
            //numbers

            List<int> numbers1 = new List<int>();
            numbers1.Add(1);

            int[] numbersToAdd = new int[10];
            numbersToAdd[0] = 10;
            numbersToAdd[1] = 20;
            numbersToAdd[2] = 30;
            numbersToAdd[3] = 40;
            numbersToAdd[4] = 50;
            numbersToAdd[5] = 60;
            numbersToAdd[6] = 70;
            numbersToAdd[7] = 80;
            numbersToAdd[8] = 90;
            numbersToAdd[9] = 100;

            //1-ci yol
            for (int i = 0; i < numbersToAdd.Length; i++)
            {
                numbers1.Add(numbersToAdd[i]);
            }

            //2-ci yol
            numbers1.AddRange(numbersToAdd);
            #endregion

            List<double> doubleList = new List<double>();
            doubleList.Add(10.1);
            doubleList.Add(20.1);
            doubleList.Add(30.1);
            doubleList.Add(40.1);

            var capacityOfDoubleList = doubleList.Capacity; //4

            var countOfDoubleList = doubleList.Count; //4

            doubleList.Add(50.1); //8 - //5

            var secondCapacityOfDoubleList = doubleList.Capacity;
            var secondCountOfDoubleList = doubleList.Count;

            doubleList.TrimExcess();

            //1. For
            //2. Foreach
            //3. While
            doubleList.ForEach(i => Console.WriteLine(i));




            #region Generic Collections general
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            int secondNumber = numbers[1];

            numbers.Insert(1, 25);

            //LINQ
            var control1 = numbers.Any(); //true
            var control2 = numbers.Any(i => i > 3); //true

            numbers.Sort(); //A-Z ve ya 1-N siralama
            numbers.Reverse(); //Z-A N-1

            bool delResult = numbers.Remove(6);
            int removedItemCount = numbers.RemoveAll(i => i > 4);

            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);
            numbers.Add(25);

            numbers.RemoveAt(2);
            //numbers.Clear();

            int maxValue = numbers.Max();
            int minValue = numbers.Min();
            int sumValue = numbers.Sum();
            #endregion
        }
    }
}
