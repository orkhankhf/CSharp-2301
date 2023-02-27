using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            //car.ToString();
            //car.Color


            Student student = new Student();
            student.Id = 1000;
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Age = 28;
            student.ClassName = "11A";
            student.Degree = "Some Degree";
            student.RegDate = DateTime.Now;


            Teacher teacher = new Teacher();
            teacher.Id = 2000;
            teacher.Name = "Orkhan";
            teacher.Surname = "Farajov";
            teacher.Age = 28;
            teacher.IsProfessor = false;
            teacher.Branch = "Some Branch";
            teacher.RegDate = DateTime.Now;

            teacher.IsProfessor = true;
            teacher.EditDate = DateTime.Now;


            Employee employee = new Employee();
            employee.Id = 3000;
            employee.Name = "Orkhan";
            employee.Surname = "Farajov";
            employee.Age = 28;
            employee.JobTitle = "Software Developer";
            employee.Salary = 100;
            employee.RegDate = DateTime.Now;

            /*
                Car:
                Id,
                Brand,
                Model,
                Km,
                Engine,
                Price,
                CreateDate,
                EditDate


                Phone:
                Id,
                Brand,
                Model,
                FastCharge,
                MadeInCountry,
                Price,
                CreateDate,
                EditDate


                Teacher:
                Id,
                Name,
                Surname,
                BirthDate,
                Gender,
                CreateDate,
                EditDate
             */
        }
    }
}
