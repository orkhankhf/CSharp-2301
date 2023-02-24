using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_Type
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        #region Inner Type required fields
        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;
        #endregion

        public Customer()
        {
            Contacts = new Contact[100];
            Addresses = new Address[100];
            Orders = new Order[100];
        }
    }
}
