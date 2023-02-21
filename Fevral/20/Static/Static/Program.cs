using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Test1();
            int faktorial10 = Faktorial(10);
            int faktorial0 = Faktorial(0);
            int faktorial5 = Faktorial(5);

            Student student;
            //student.Name = "Orkhan";

            Student.Test1();

            student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhankhf@gmail.com";
            student.Test();

            #region Task in Lesson 1
            var normalName = StringHelper.CheckFullname("Orkhan", "Farajov");
            var longFullname = StringHelper.CheckFullname("OrkhanOrkhanOrkhan", "Farajov");
            var longFullname2 = StringHelper.CheckFullname("Orkhan Middlename", "Farajov");
            var longFullname3 = StringHelper.CheckFullname("Orkhan Ibn Khayyam", "Farajov");
            #endregion


            #region Task in Lesson 2
            Staff st = new Staff();
            st.Name = "Orkhan";
            st.Surname = "Farajov";
            st.Email = "orkhan.farajov";
            st.Gender = 1;
            #endregion


            #region Task in Lesson 3
            Staff st1 = new Staff();
            st1.Name = "Samir";
            st1.Surname = "Samirov";
            st1.Email = "samir";
            st1.Gender = 1;

            EmailHelper.SendWelcomeMail(st.Email);

            EmailHelper.SendPasswordChangeMail(st.Email);
            #endregion
        }

        static int Faktorial(int num) //This is a recursive method.
        {
            if (num == 0)
                return 1;

            return num * Faktorial(num - 1);
        }
    }
}
