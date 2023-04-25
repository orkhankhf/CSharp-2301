using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Delegate

            #region Calc without delegate
            void Addition(int a, int b) //Toplama
            {
                Console.WriteLine("Toplama neticesi: " + (a + b));
            }

            void Subtraction(int a, int b) //Cixma
            {
                Console.WriteLine("Cixma neticesi: " + (a - b));
            }

            void Multiplication(int a, int b) //Vurma
            {
                Console.WriteLine("Vurma neticesi: " + (a * b));
            }

            void Division(int a, int b) //Bolme
            {
                Console.WriteLine("Bolme neticesi: " + (a / b));
            }

            Addition(10, 20);
            Subtraction(60, 25);
            Multiplication(2, 20);
            Division(10, 5);
            #endregion

            Calc delegateCalc = new Calc(Addition);

            //delegateCalc.Invoke(10, 20);

            delegateCalc += Subtraction;
            delegateCalc += Multiplication;
            delegateCalc += Division;

            Console.Clear();

            delegateCalc.Invoke(10, 20);

            int OtherMethod(bool a)
            {
                return 0;
            }
            //delegateCalc += OtherMethod;


            Delegate[] delegates = delegateCalc.GetInvocationList();

            foreach (var item in delegates)
            {
                Console.WriteLine($"Method name: " + item.Method.Name);
                Console.WriteLine($"Return type: " + item.Method.ReturnType.Name);
                Console.WriteLine($"Is static: " + item.Method.IsStatic);
                Console.WriteLine($"Is private: " + item.Method.IsPrivate);
                Console.WriteLine($"Is constructor: " + item.Method.IsConstructor);
                Console.WriteLine($"Is abstract: " + item.Method.IsAbstract);
            }

            Console.Clear();

            delegateCalc -= Subtraction;

            foreach (var item in delegateCalc.GetInvocationList())
            {
                Console.WriteLine($"Method name: " + item.Method.Name);
            }

            delegateCalc += Subtraction;

            foreach (var item in delegateCalc.GetInvocationList())
            {
                Console.WriteLine($"Method name: " + item.Method.Name);
            }

            //Lambda expression istifade qaydasi
            ShowPersonInfo delegateWithLambda = (Person p) => Console.WriteLine($"Name: {p.Name} Surname: {p.Surname}");
            Person person = new Person("Orkhan", "Farajov", 28, "orkhankhf@gmail.com");
            delegateWithLambda.Invoke(person);

            delegateWithLambda = (Person p) => Console.WriteLine($"{p.Name} is {p.Age} years old. Contact: {p.Email}");

            delegateWithLambda.Invoke(person);
            delegateWithLambda(person);

            ShowPersonInfo delegateWithUnnamedMethod = new ShowPersonInfo(delegate (Person p)
            {
                Console.WriteLine($"Hello {p.Name} {p.Surname}! You are {p.Age} years old and your email is {p.Email}");
            });
            delegateWithUnnamedMethod(person);

            #endregion
        }

        delegate void Calc(int a, int b);

        public delegate void ShowPersonInfo(Person person);
    }
}
