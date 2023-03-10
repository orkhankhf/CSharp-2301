using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract
            //BaseClass bc = new BaseClass();
            Customer customer = new Customer();

            customer.Test();

            customer.ShowTime();

            //C-reate
            //R-ead
            //U-pdate
            //D-elete

            VipCustomer vip = new VipCustomer();
            vip.ShowTime();
            #endregion


            #region Interface
            Student student = new Student();
            student.Add("Orkhan", "Farajov");
            student.Update(1, "Orxan", "Ferecov");
            student.Delete(1);
            student.ShowStudentInfo();
            #endregion
        }
    }
}
