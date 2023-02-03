using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.HelloStudent();

            student.ShowOrkhansInformation();

            //student.ShowStudentInfo("Orxan", "Ferecov"); xeta verecek cunki private method'dur
            
            User user = new User();
            user.Login("admin", "123456");
        }

        static void SayHello()
        {
            Console.WriteLine("Salam");
        }
    }
}
