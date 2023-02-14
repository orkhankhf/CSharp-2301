using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    class Customer
    {
        /*
         -Ad
         -Soyad
         -Cinsiyyət
         -Pasport seriyası və nömrəsi
         -Ünvanı
        */
        public string Name;
        public string Surname;
        public int Gender; //1 kisi, 0 qadin
        public string DocumentSerial;
        public string DocumentNumber;
        public string Address;

        public Customer()
        {
            DocumentNumber = "000000";
            DocumentSerial = "AZ";
        }

        //Overload 1
        public Customer(string documentNumber)
        {
            DocumentNumber = documentNumber;
        }

        //Overload 2
        public Customer(string documentNumber, string documentSerial)
        {
            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
        }

        //Overload 3
        public Customer(string documentNumber, string documentSerial, string name, string surname)
        {
            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
            Name = name;
            Surname = surname;
        }

        //Overload 4
        public Customer(int gender, string name, string surname)
        {
            Gender = gender;
            Name = name;
            Surname = surname;
        }

        //Overload 5
        public Customer(string documentNumber, string documentSerial, int gender, string name, string surname, string address)
        {
            DocumentNumber = documentNumber;
            DocumentSerial = documentSerial;
            Gender = gender;
            Name = name;
            Surname = surname;
            Address = address;
        }

        #region Methods in Classes
        private bool CheckCustomerFromDb()
        {
            string[] customers = new string[] { "Orkhan", "Valeh", "Gunel" };
            return customers.Contains(Name);
        }

        public bool CheckCustomer()
        {
            bool result = CheckCustomerFromDb();
            return result;
        }

        public void Register()
        {
            Console.WriteLine("Qeydiyyatdan kecirildi!");
        }
        #endregion
    }
}
