using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Add(string name, string surname)
        {
            Console.WriteLine("Telebe bazaya elave edildi.");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Telebe bazadan silindi.");
        }

        public void Update(int id, string name, string surname)
        {
            Console.WriteLine("Telebe melumatlari yenilendi.");
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("Telebe melumatlari: {0}, {1}", Name, Surname);
        }
    }
}
