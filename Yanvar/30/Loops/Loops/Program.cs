using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Loops
            //Numune 1
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Salam");
            }

            Console.Clear();

            //Nümunə 2: 0-9
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Nümunə 3: 1-10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Nümunə 4: 0-8
            for (int i = 0; i < 10; i += 2) //i = i + 2;
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Nümunə 5:
            for (int i = 0; i < 100; i += 10)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Nümunə 6:
            //intinify loop
            //for (; ;)
            //{
            //    Console.WriteLine("Hi");
            //}

            //int counter = 0;
            //for (; ; counter++)
            //{
            //    Console.WriteLine("Counter: " + counter);
            //}


            //Nümunə 8:
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Oneline for: " + i);

            Console.Clear();

            //Nümunə 9: break keyword
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Counter: " + i);
            }

            Console.Clear();

            //Nümunə 9: nested loop
            for (int i = 0; i < 60; i++) //deqiqe
            {
                for (int x = 0; x < 60; x++) //saniye
                {
                    Console.WriteLine(i + ":" + x);
                }
                Console.WriteLine("__________________");
            }

            Console.Clear();

            //Nümunə 10: nested loop 2
            for (int a1 = 0; a1 < 10; a1++) //saat
            {
                for (int b1 = 0; b1 < 10; b1++) //deqiqe
                {
                    for (int c1 = 0; c1 < 10; c1++) //saniye
                    {
                        for (int d1 = 0; d1 < 10; d1++) //millisaniye
                        {
                            Console.WriteLine("a:" + a1 + " --- b:" + b1 + " --- c:" + c1 + " --- d:" + d1);
                        }
                    }
                }
            }

            //Nümunə 11: Yolka ağacı
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #region Task in Lesson 1
            /*
             Task 1: 1-dən 100-ə qədər olan rəqəmlərin toplamını ekrana yazdırın.
             Task 2: Sadəcə cüt rəqəmlərin toplamını ekrana yazdırın.
             */
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                    sum += i;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
            #endregion
            #endregion



            #region While Loop
            //Nümunə 1:
            var continueLoop = true;

            while (continueLoop)
            {
                int sec = DateTime.Now.Second;

                if (sec > 30 && sec < 45)
                {
                    Console.WriteLine("End");
                    break;
                }
                else //(yazılmaya da bilər)
                    Console.WriteLine(sec);
            }

            //Nümunə 2:
            int countWhile = 1;
            while (countWhile <= 100)
            {
                Console.WriteLine("Counter: " + countWhile);
                countWhile++;
            }

            /*
             Task 1: Belə bir kiçik app yazın ki, dayanmadan istifadəçidən bir text alın və istifadəçi text 
                     yerinə exit sözünü yazana qədər bu davam etsin.
             */

            //1-ci variant
            while (true)
            {
                string word = Console.ReadLine().ToLower();
                if (word != "exit")
                    Console.WriteLine(word);
                else
                    break;
            }

            //1-ci variant
            var stopLoop = false;
            while (!stopLoop)
            {
                string text = Console.ReadLine();
                if (text != "exit")
                    Console.WriteLine(text);
                else
                    stopLoop = true;
            }

            bool start = false;

            while (start)
            {
                if (start == false)
                {
                    Console.WriteLine("Chat baslasin? (He/Yox)");
                    string yesNo = Console.ReadLine();

                    if (yesNo == "He")
                        start = true;
                    else if (yesNo == "Yox")
                        break;
                    else
                    {
                        Console.WriteLine("Sehv cavab verdiniz!");
                        Console.WriteLine("Chat baslasin? (He/Yox)");
                    }
                }
                else
                {
                    Console.WriteLine("Mesaji yazin...");
                    string message = Console.ReadLine();

                    if (message == "exit")
                        break;

                    Console.WriteLine(message);
                }
            }



            do
            {
                if (start == false)
                {
                    Console.WriteLine("Chat baslasin? (He/Yox)");
                    string yesNo = Console.ReadLine();

                    if (yesNo == "He")
                        start = true;
                    else if (yesNo == "Yox")
                        break;
                    else
                    {
                        Console.WriteLine("Sehv cavab verdiniz!");
                        Console.WriteLine("Chat baslasin? (He/Yox)");
                    }
                }
                else
                {
                    Console.WriteLine("Mesaji yazin...");
                    string message = Console.ReadLine();

                    if (message == "exit")
                        break;

                    Console.WriteLine(message);
                }
            } while (start);
            #endregion


            #region Foreach
            string[] names = new string[5];
            names[0] = "Orkhan";
            names[1] = "Valeh";
            names[2] = "Elnur";
            names[3] = "Cabir";
            names[4] = "Samir";

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Variable declarations inside/outside loop bodies
            string car = "Mercedes";

            for (int i = 0; i < 5; i++)
            {
                car = "Audi";
                int age = 5;
                age = 10;
            }

            while (true)
            {
                car = "BMW";
                break;
            }

            //age = 2; //age'in deyeri burada deyisdirile bilmez!
            #endregion

            Random random = new Random();
            int number = random.Next(1, 100);




            #region Dersde kecirilenler
            for (int i = 0; i < 10; i++)
            {

            }

            int a = 3;

            while (a < 5)
            {
                a++;
            }

            do
            {
                a++;
            } while (a < 5);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
