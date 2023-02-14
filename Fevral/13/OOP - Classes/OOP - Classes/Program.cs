using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Begin
            /*
                -Müştəri
                -Satış təmsilcisi
                -Satılacaq məhsul
                -Təklif
                -Sifariş
                -Qəbz


                    -Müştəri
                        -Ad
                        -Soyad
                        -Cinsiyyət
                        -Pasport seriyası və nömrəsi
                        -Ünvanı

                    -Məhsul
                        -Marka
                        -Model
                        -İl
                        -Km
                        -Yanacaq növü
                        -Ban növü
                    
                    -Təklif
                        -Təklif nömrəsi
                        -Müştəri
                        -Satıcı
                        -Məhsul
                        -Qiymət

                    -Sifariş
                        -Sifariş nömrəsi
                        -Təklif
                        -Qiymət
                    
                    -Qəbz
                        -Vergi nömrəsi
                        -Qəbz nömrəsi
                        -Seriyası
                        -Təklif
                        -Müştəri
             */
            Console.WriteLine("Hello");
            string name = "Resul";


            Customer orkhan = new Customer();
            orkhan.Name = "Orkhan";
            orkhan.Surname = "Farajov";
            orkhan.Gender = 1;
            orkhan.DocumentSerial = "AZ";
            orkhan.DocumentNumber = "123456";
            orkhan.Address = "Baki seh. Nerimanov r-nu, X kucesi...";

            Customer otherCustomer = new Customer();


            otherCustomer = orkhan;

            otherCustomer.Name = "Name changed for otherCustomer";
            orkhan.Surname = "Surname changed for orkhan";

            otherCustomer = null;
            orkhan = null;

            //string customerName = orkhan.Name;
            //string otherCustomerName = otherCustomer.Name;
            #endregion

            #region Constructor methods
            Customer customer2 = new Customer();


            Customer defaultCtor = new Customer();
            Customer overload1 = new Customer("123456");
            Customer overload2 = new Customer("123456", "AA");
            Customer overload3 = new Customer("123456", "AA", "Orkhan", "Farajov");
            Customer overload4 = new Customer(28, "Orkhan", "Farajov");
            Customer overload5 = new Customer("123456", "AA", 28, "Orkhan", "Farajov", "Baki seheri, Filan rayon...");
            
            Student st = new Student("Orkhan", "Farajov", 28);

            Customer newRegistration = new Customer();
            newRegistration.Name = "Mark";
            newRegistration.Surname = "Henry";
            newRegistration.DocumentNumber = "555555";
            newRegistration.DocumentSerial = "US";
            newRegistration.Address = "Some address...";

            bool isUserDuplicate = newRegistration.CheckCustomer();

            if (!isUserDuplicate)
            {
                newRegistration.Register();
            }
            #endregion
        }
    }
}
