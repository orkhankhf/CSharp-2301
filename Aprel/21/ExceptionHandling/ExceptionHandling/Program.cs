using ExceptionHandling.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is Exception Handling?

            Console.WriteLine("Bir eded daxil edin: ");
            int outVal;
            int.TryParse(Console.ReadLine(), out outVal);

            Console.WriteLine("Bir eded daxil edin: ");
            int num1 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("Bir eded daxil edin: ");
                int num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //(bu sətirdə exception detallarını server'də bir fayla yaza bilərəm)
            }

            #region Exception Types

            #region NullReferanceException
            string[] names = null;

            //var firstElementOfNullArray = names[1].Length; //error

            //var notReadableCode = 0;

            try
            {
                var firstElementOfNullArray = names[1].Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Array bosdur!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var readableCode = 0;
            #endregion

            #region DivideByZeroException
            try
            {
                Console.WriteLine("Bolmek istediyiniz ededleri daxil edin: ");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());

                decimal divideResult = a / b;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Eded 0-a bolune bilmez!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yuxarida hec bir catch'a girmediyi zaman bura girecek.");
            }
            #endregion

            #region KeyNotFoundException
            try
            {
                var keyValuePair = new Dictionary<string, string>();
                keyValuePair.Add("one", "bir");
                keyValuePair.Add("two", "iki");
                keyValuePair.Add("three", "uc");

                var one = keyValuePair["one"];
                var five = keyValuePair["five"]; //error
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Axtardiginiz key movcud deyil!");
            }
            #endregion

            #region IndexOutOfRangeException
            try
            {
                int[] intArray = new int[10];

                for (int i = 0; i < 20; i++)
                {
                    intArray[i] = i;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array'in index araligindan kenar bir index'e muraciet olundu!");
            }
            #endregion

            #endregion


            #region When
            try
            {
                Console.WriteLine("Zehmet olmasa 20-30 araliginda cut reqem daxil edin: ");
                var input = int.Parse(Console.ReadLine());

                if (input % 2 != 0)
                    throw new FormatException("NotDoubleDigit");

                if (!(input >= 20 && input <= 30))
                    throw new FormatException("NotCorrectRange");
            }
            catch (FormatException ex) when (ex.Message == "NotDoubleDigit")
            {
                Console.WriteLine("Daxil edilen reqem cut reqem deyil!");
            }
            catch (FormatException ex) when (ex.Message == "NotCorrectRange")
            {
                Console.WriteLine("Daxil edilen reqem cutdur, ancaq 20-30 araliginda deyil!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Xahis olunur reqem daxil edin!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion



            #region Finnaly block
            try
            {
                Console.WriteLine("Connected to database...");
                Console.WriteLine("Database connection is open");
                Console.WriteLine("Get user with id 5");
                var userInput = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Daxil edilen deyer reqem deyil!");
                Console.WriteLine("Write to log: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Her hansisa bir xeta bas verdi!");
                Console.WriteLine("Write to log: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Database connection is closed...");
            }
            #endregion


            #region Custom Exception Types
            try
            {
                int ageOfUser = int.Parse(Console.ReadLine());

                if (ageOfUser < 18)
                    throw new AgeNotAllowedException();
            }
            catch (AgeNotAllowedException ex)
            {
                Console.WriteLine("Istifadeci 18 yasindan kicik ola bilmez!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Daxil edilen deyer reqem deyil!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta bas verdi!");
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
