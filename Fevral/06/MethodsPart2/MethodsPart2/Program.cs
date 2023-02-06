using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parameter with default value
            ShowDate(DateTime.Now.Day, DateTime.Now.Month);
            ShowDate(DateTime.Now.Day, DateTime.Now.Month, 2025);
            #endregion

            #region Ref / Out keywords
            int test = 0; //stack'da yaranir
            SetRef(ref test); //10

            int num2;
            SetOut(out num2);

            int numberVal = 0;
            bool booleanVal;

            booleanVal = PractiseOutKeyword("15", out numberVal);
            #endregion

            #region Params
            GetSum(15, 20, 85, 94, 45);
            GetSum(15, 20, 85, 94, 45, 78, 45);
            GetSum(15, 20, 85, 94, 45, 100, 56, 78, 95, 155, 201);
            GetSum(15, 20);
            #endregion

            #region Overloading
            AdditionNums(45, 50);
            AdditionNums(75.4m, 84.6m);
            AdditionNums("4", "44");
            #endregion


            #region Call methods as parameter
            decimal a = Subtraction(20.1m, 4.5m);
            ShowValue(a);

            ShowValue(Subtraction(20.1m, 4.5m));
            #endregion


            #region Local functions
            AdditionWithLocalFunc(700, 300);
            SecondAdditionWithLocalFunc(500, 250, 350, 800);
            Console.Clear();
            ThirdAdditionWithLocalFunc(500, 250, 350, 800);
            #endregion

            #region Method types
            var dateTime = DateTime.Now;
            int dayOfDateTime = GetDay(dateTime);

            Method1();

            Method2("Orxan", "Ferecov");

            DateTime dt = GetTime();
            #endregion
        }

        #region Parameter with default value
        public static void ShowDate(int day, int month, int year = 2022)
        {
            Console.WriteLine("Tarix: {0}-{1}-{2}", day, month, year);
        }
        #endregion

        #region Ref / Out keywords
        static void SetRef(ref int intValue)
        {
            intValue = 10;
        }

        static void SetOut(out int intValue)
        {
            intValue = 15;
        }

        static bool PractiseOutKeyword(string value, out int result)
        {
            var numberValue = 50;
            result = numberValue;

            var booleanValue = true;
            return booleanValue;
        }
        #endregion


        #region Params
        static void GetSum(int test, params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Toplam: " + sum);
        }
        #endregion


        #region Overloading
        static void AdditionNums(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(string num1, string num2)
        {
            decimal total = decimal.Parse(num1) + decimal.Parse(num2);
            Console.WriteLine(total);
        }
        #endregion



        #region Call methods as parameter
        static void ShowValue(decimal obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        #endregion


        #region Local functions
        static void AdditionWithLocalFunc(int num1, int num2)
        {
            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int result = Addition(num1, num2);

            Console.WriteLine("Netice: " + result);
        }


        static void SecondAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int Addition(int num1Local, int num2Local)
            {
                int SecondAddition(int num3Local, int num4Local)
                {
                    return num3Local + num4Local;
                }

                int secondResult = SecondAddition(num3, num4);

                return secondResult + num1Local + num2Local;
            }

            int result = Addition(num1, num2);

            Console.WriteLine("Netice: " + result);
        }


        static void ThirdAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int result = 0;

            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int SecondAddition(int num3Local, int num4Local)
            {
                return num3Local + num4Local;
            }

            result += Addition(num1, num2);
            result += SecondAddition(num3, num4);

            Console.WriteLine("Netice: " + result);
        }
        #endregion

        #region Method types
        static void Method1()
        {
            Console.WriteLine("Salam");
        }

        static void Method2(string name, string surname)
        {
            Console.WriteLine("Salam " + name + " " + surname);
        }

        static DateTime GetTime()
        {
            var now = DateTime.Now;
            return now;
        }

        static int GetDay(DateTime dateTime)
        {
            return dateTime.Day;
        }
        #endregion
    }
}
