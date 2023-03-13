using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericCustomer<T>
    {
        public int Id { get; set; }
        public T Name { get; set; }
        public T Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public T DocumentSerial { get; set; }
        public T DocumentNo { get; set; }
        public T PlaceOfBirth { get; set; }
    }
}
