using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value-Types
            //Nümunə 1
            int a;
            a = 5;

            //Nümunə 2
            int b;
            b = 5;
            b = 2147483647;

            //Nümunə 3
            int i = 2147483647; // int Ram'da 4 byte yer bron edir
            double x = 500; // double Ram'da 8 byte yer bron edir
            x = i;
            //i = x;

            x = 150;
            #endregion

            #region Referance-Types
            Student student;

            //student.Name = "Orkhan"; //(error)
            
            student = new Student();

            student.Name = "Ceyhun";
            student.Age = 27;
            student.Point = 78.5d;
            #endregion

            #region Reason of NullReferanceException
            //var studentClassNumber = student.ClassRoom.Number; // NullReferanceException
            #endregion


            #region Assign one Referance Type to another
            Student otherStudent = new Student();
            otherStudent.Name = "Babek";
            otherStudent.Age = 29;
            otherStudent.Point = 71.6d;

            student = otherStudent;

            otherStudent.Name = "Orxan";
            #endregion


            #region String helper methods
            string employee = "Orkhan Farajov";
            string upperCase = employee.ToUpper();
            string lowerCase = employee.ToLower();
            string partOfString = employee.Substring(2, 4);
            #endregion
        }
    }
}
