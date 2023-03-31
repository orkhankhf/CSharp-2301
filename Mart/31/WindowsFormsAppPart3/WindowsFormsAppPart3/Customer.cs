using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart3
{
    public class Customer
    {
        public Guid Id { get; set; }
        //Example: GF6B2GF-1GFN51-5FGN51-5FG1N

        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + FatherName + " " + Email + " " + PhoneNumber;
        }
    }
}
