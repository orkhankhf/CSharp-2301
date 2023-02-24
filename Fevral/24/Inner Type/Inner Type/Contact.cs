using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_Type
{
    public class Contact
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
