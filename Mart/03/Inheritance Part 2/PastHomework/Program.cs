using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 2:             Aşağıda yazdığım class'ların property'lərini base class'a çıxardıb inherit almaq lazımdır. Nəyi necə edəcəyinizə qarışmıram özünüz qərar verin...Employee: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, RegUser, RegDate, EditUser, EditDate, DeletedTeacher: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, Branch, Level, RegUser, RegDate, EditUser, EditDate, DeletedStudent: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, Department, Level, RegUser, RegDate, EditUser, EditDate, Deleted
             */
            Teacher teacher = new Teacher();
            teacher.Id = 1;
            teacher.Name = "Orkhan";
            teacher.Surname = "Farajov";
            teacher.ReferanceNumber = "123456";
            teacher.Level = "Some Level";
            teacher.RegDate = DateTime.Now;
            teacher.RegUser = 135;
        }


        public static void EditTeacherInfo()
        {
            //burada database'e sorgu gedir ve Id'si meselen, 1 olan data alinir.
            Teacher teacher = new Teacher();
            teacher.Name = "Orxan";
            teacher.EditDate = DateTime.Now;
            teacher.EditUser = 356;
        }

        public static void DeleteTeacherInfo(int id)
        {
            //burada database'e sorgu gedir ve Id'si meselen, 1 olan data alinir.
            Teacher teacher = new Teacher();
            teacher.IsDeleted = true;
        }
    }
}
