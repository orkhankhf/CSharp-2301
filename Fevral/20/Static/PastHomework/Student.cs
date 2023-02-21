using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    public class Student
    {
        private string _name;
        private string _surname;
        private string _email;

        public string Surname {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
                if (_name != null)
                {
                    this._email = string.Format("{0}.{1}@gmail.com", _name.ToLower(), _surname.ToLower());
                    //this._email = $"{_name.ToLower()}.{_surname.ToLower()}@gmail.com";
                }
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                if (_surname != null)
                {
                    this._email = string.Format("{0}.{1}@gmail.com", _name.ToLower(), _surname.ToLower());
                    //this._email = $"{_name.ToLower()}.{_surname.ToLower()}@gmail.com";
                }
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }
            private set { }
        }
    }
}
