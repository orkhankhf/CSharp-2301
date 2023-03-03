using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Part_2
{
    public class Person
    {
        #region Constructor methods while inheritance
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        public Person()
        {
            Console.WriteLine("Constructor of Person class");
            GenerateId();
        }

        private void GenerateId()
        {
            Random rand = new Random();
            this.Id = rand.Next(1, 99999);
        }
        #endregion

        #region Access to base class methods
        public void GoodPerson()
        {
            Console.WriteLine("Good Person!");
        }
        #endregion
    }
}
