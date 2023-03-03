using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor methods while inheritance
            Teacher teacher = new Teacher();

            Student student = new Student();
            #endregion


            #region Access to base class methods
            Person person = new Person();
            person.GoodPerson();

            Teacher teacher2 = new Teacher();
            teacher2.GoodPerson();
            #endregion

            #region Assignment sub class to parent class
            Student student1 = new Student();
            object obj = student1;

            //Student s1 = obj;
            Student s1 = (Student)obj;

            Person p1;
            p1 = s1;
            p1 = new Teacher();

            //eksi
            //s1 = new Person();
            s1 = (Student)p1;
            s1 = (Student)new Person();

            object objPerson = new Person();
            object objTeacher = new Teacher();
            object objStudent = new Student();
            #endregion
        }
    }
}
