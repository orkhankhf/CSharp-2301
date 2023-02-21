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
            Student st = new Student();
            st.Name = "Orkhan";
            st.Surname = "Farajov";

            Student st1 = new Student();
            st1.Surname = "Farajov";
            st1.Name = "Orkhan";
        }
    }
}
