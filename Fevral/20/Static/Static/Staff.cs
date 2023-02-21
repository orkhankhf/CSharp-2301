using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Staff
    {
        public static string domain = "oxu.az";
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; } //1=Male, 0=Female

        private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value.ToLower() + "@" + Staff.domain;
            }
        }
    }
}
