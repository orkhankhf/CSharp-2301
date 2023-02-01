using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region How to create a instance of Arrays
            //Numune 1
            int[] numArray = new int[6];

            numArray[0] = 100;

            int getVal = numArray[0];

            //Numune 2
            int[] secondNumArray;
            secondNumArray = new int[6];

            //Numune 3
            int[] thirdNumArray = new int[6]
            {
                1,
                2,
                3,
                4,
                5,
                6
            };
            thirdNumArray[5] = 5; //Index out of range xetasi bas verecek

            //Numune 4
            int[] fourthNumArray = new int[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                4
            };
            #endregion


            #region Use Arrays with diffrent data types
            //string
            string[] names = new string[5];
            names[0] = "Orkhan";
            names[1] = "John";
            names[2] = "Mark";
            names[3] = "Jeff";
            names[4] = "Bill";
            //names[5] = "test"; //Index out of range xetasi bas verecek

            var orkhan = names[0];
            var john = names[1];
            var mark = names[2];
            var jeff = names[3];
            var bill = names[4];
            //var test = names[5]; //Index out of range xetasi bas verecek


            //char
            char[] alphabet = new[]
            {
                'A', //0-cı element
                'B', //1-ci element
                'C', //2-ci element
                'D'  //3-cü element
            };

            char a = alphabet[0];
            char b = alphabet[1];
            char c = alphabet[2];
            char d = alphabet[3];


            //object
            object[] objArr = new object[7];
            objArr[0] = 5;
            objArr[1] = "string type";
            objArr[2] = true;
            objArr[3] = 2.5f;
            objArr[4] = DateTime.Now;
            objArr[5] = 99999999999999999;

            DateTime date = new DateTime(1995, 12, 12);
            objArr[6] = date;

            int intType = (int)objArr[0];
            string stringType = (string)objArr[1];
            bool boolType = (bool)objArr[2];
            float floatType = (float)objArr[3];
            DateTime dateTimeType = (DateTime)objArr[4];
            long longType = (long)objArr[5];
            DateTime dateTimeType2 = (DateTime)objArr[6];
            #endregion




            #region Loop Arrays

            #region Task in Lesson 1
            Console.WriteLine("Sinifde nece telebe var?");
            short studentCount = Convert.ToInt16(Console.ReadLine()); //15

            string[] students = new string[studentCount];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(i + ". Telebenin adini daxil edin: ");
                string studentName = Console.ReadLine();
                students[i] = studentName;
            }
            Console.Clear();

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            #endregion


            #region Task in Lesson 2
            Console.WriteLine("Sinifde neçe telebe olacaq?");
            int stCount = Convert.ToInt32(Console.ReadLine());
            string[] stNames = new string[stCount];
            byte[] stAges = new byte[stCount];

            for (int i = 0; i < stCount; i++)
            {
                Console.WriteLine(i + ". Telebenin adini daxil edin:");
                string stName = Console.ReadLine();

                Console.WriteLine(i + ". Telebenin yasini daxil edin:");
                byte stAge = Convert.ToByte(Console.ReadLine());

                stNames[i] = stName;
                stAges[i] = stAge;
            }

            for (int i = 0; i < stCount; i++)
            {
                Console.WriteLine(i + ". " + stNames[i] + " " + stAges[i] + " yasindadir.");
            }
            #endregion


            foreach (var item in stNames)
            {
                Console.WriteLine(item);
            }
            #endregion



            #region Multidimensional Arrays
            //5x2 (Matris Array)
            int[,] _5x2 = {
                { 1, 2},
                { 3, 4},
                { 5, 6},
                { 7, 8},
                { 9, 10}
            };

            //(Jagged Array)
            int[][] jaggedArr = new int[][]
            {
                new int[2] { 100, 200}, //Array
                new int[6] { 101, 102, 103, 104, 105, 106}, //Array
                new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, //Array
                new int[] { 1000, 2000, 3000, 4000, 5000 } //Array
            };

            jaggedArr[0][0] = 500;
            jaggedArr[2][3] = 15;

            for (int i = 0; i < jaggedArr.Length; i++) //4
            {
                for (int x = 0; x < jaggedArr[i].Length; x++)
                {
                    Console.WriteLine(i + "." + x + ": " + jaggedArr[i][x]);
                }
            }
            #endregion



            #region Array Methods
            /*
             Properties:
                IsFixedSize - Element saylarının sabit olub olmamasını bildirir. (bool)
                IsReadOnly - Element dəyərlərinin dəyişdirilə bilməsi barədə məlumat. (bool)
                Length - Array'ın ölçüsü (neçə elementi olduğu) barədə məlumat. (int)

             Methods:
                Clone() - Array'ı olduğu kimi klonlayır.
                Array.IndexOf() - bir array'dakı elementin index'ini verir.
                CopyTo() - Array'ı başqa bir Array'a kopyalayır.
                Sort() - Artan sıra ilə sıralayır.
                Reverse() - Tərsinə sıralayır.
                Clear() - Array'ın elementlərinin dəyərlərini default dəyərə resetləyir.
             */

            string[] persons = new string[]
            {
                "Orxan Ferecov",
                "Bill Gates",
                "Steve Jobs",
                "Mark Zuckenberg"
            };

            bool test = persons.IsFixedSize;
            bool isReadOnly = persons.IsReadOnly;
            int length = persons.Length;

            var clonedArray = persons.Clone();
            int stevesIndex = Array.IndexOf(persons, "Steve Jobs");

            string[] copiedPersons = new string[10];
            persons.CopyTo(copiedPersons, 4);

            Array.Sort(persons);
            Array.Reverse(persons);

            Array.Clear(persons, 2, 1);
            #endregion
        }
    }
}
