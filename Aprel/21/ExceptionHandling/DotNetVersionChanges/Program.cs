using DotNetVersionChanges.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVersionChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Interpolation
            string name = "Orkhan";
            string surname = "Farajov";
            int age = 28;
            string job = "Software Developer";

            //Before String Interpolation
            var personInfo = name + " " + surname + " " + age.ToString() + " years old and works as a " + job;
            var personInfo2 = string.Format("{0} {1} is {2} years old and works as a {3}", name, surname, age, job);

            //After String Interpolation
            var personInfoNewVers = $"{name} {surname} is {age} years old and works as a {job}";
            var personInfoNewVers2 = $"{name} {surname, 20}";
            #endregion


            #region Var keyword
            string fullname = "Orkhan Farajov";
            Console.WriteLine(fullname);

            string car = "Mercedes";
            var model = "S500";


            Student st1 = new Student()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                Age = 28
            };

            var student = new
            {
                Id = 1,
                Ad = "Orkhan",
                Surname = "Farajov",
                Age = 28
            };
            #endregion



            #region Local functions
            float Math(int a, int b, MathOperand operand)
            {
                switch (operand)
                {
                    case MathOperand.Addition:
                        return a + b;
                    case MathOperand.Subtraction:
                        return a - b;
                    case MathOperand.Multiplication:
                        return a * b;
                    case MathOperand.Division:
                        if (b != 0)
                            return a / b;
                        else
                            return 0;
                    case MathOperand.EqualsTo:
                        if (a == b)
                            return 1;
                        else
                            return 0;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            var res = Math(5, 10, MathOperand.Multiplication);
            #endregion


            #region Task in Lesson 1
            float multiplication(float a, float b = 10)
            {
                return a * b;
            }

            var res1 = multiplication(20, 5); //100
            var res2 = multiplication(20); //200

            //void testMethod(int a, int b, int c = 1, int d)
            //{

            //}
            void testMethod(int a, int b, int c = 1, int d = 2)
            {

            }
            testMethod(10, 20, 30);
            #endregion


            #region Tuple use
            Tuple<string, string, int, string, List<Student>, string> tupleVariable =
                new Tuple<string, string, int, string, List<Student>, string>
                ("Orkhan", "Farajov", 28, "Software Developer", new List<Student>(), "7-8");

            var tplName = tupleVariable.Item1;
            var tplSurname = tupleVariable.Item2;
            var tplAge = tupleVariable.Item3;
            var tplJob = tupleVariable.Item4;
            var tplStudents = tupleVariable.Item5;
            var tplExperience = tupleVariable.Item6;

            Tuple<string, string> getPerson()
            {
                return new Tuple<string, string>("Orkhan", "Farajov");
            }

            Tuple<string, string> person = getPerson();

            Console.WriteLine($"Name: {person.Item1} Surname: {person.Item2}");

            (string Name, string Surname) getPerson1()
            {
                return ("Orkhan", "Farajov");
            }

            (string, string) person1 = getPerson1();

            Console.WriteLine($"Name: {person1.Item1} Surname: {person1.Item2}");
            #endregion
        }
    }
}
