using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        
        public Student(string name, string surname, int age)
        {
            if(age > 35)
            {
                Console.WriteLine("Telebe 35 yasdan boyuk ola bilmez.");
            }
            else
            {
                Name = name;
                Surname = surname;
                Age = age;
            }
        }
    }
}
