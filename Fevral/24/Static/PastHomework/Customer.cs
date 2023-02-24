using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    public class Customer
    {
        #region Virtual Database
        private static ArrayList database;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        #endregion

        #region Encapsulation
        public string _username;
        public string _password;

        public string Username {
            get
            {
                return this._username;
            }
            set
            {
                bool isUsernameDuplicate = CheckDuplicateUsername(value);

                if (isUsernameDuplicate)
                    Console.WriteLine("Elave etmek istediyiniz username artiq sistemde movcuddur!");
                else
                    this._username = value;
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                bool isPasswordValid = IsPasswordValid(value);
                if (!isPasswordValid)
                    Console.WriteLine("Sifre en az 8 simvoldan ibaret, icinde en az 1 boyuk herf ve 1 reqem olmalidir.");
                else
                    this._password = value;
            }
        }
        #endregion

        #region Constructor
        static Customer()
        {
            database = new ArrayList();
        }
        #endregion

        #region Static methods
        static bool CheckDuplicateUsername(string username)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Customer tempCustomer = (Customer)database[i];

                if (tempCustomer.Username == username)
                    return true;
            }

            return false;
        }

        static bool CheckDuplicateEmail(string email)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Customer tempCustomer = (Customer)database[i];

                if (tempCustomer.Email == email)
                    return true;
            }
            return false;
        }

        public static void AddCustomer(Customer customer)
        {
            if(customer != null && !string.IsNullOrEmpty(customer.Username) && !string.IsNullOrEmpty(customer.Email))
            {
                bool isEmailDuplicate = CheckDuplicateEmail(customer.Email);

                if(isEmailDuplicate)
                    Console.WriteLine("Elave etmek istediyiniz email artiq sistemde movcuddur!");
                else
                {
                    database.Add(customer);
                    Console.WriteLine("Yeni musteri sisteme elave olundu!");
                }
            }
        }

        public bool IsPasswordValid(string password)
        {
            bool valid = false;

            if(password.Length >= 8)
            {
                bool upperLetter = false, number = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]) && char.IsLetter(password[i]) && !upperLetter)
                        upperLetter = true;

                    if (char.IsNumber(password[i]) && !number)
                        number = true;
                }
                valid = (upperLetter && number);
            }

            return valid;
        }
        #endregion
    }
}
