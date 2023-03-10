using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        public BaseClass()
        {
            CreateDate = DateTime.Now;
        }

        public void Test()
        {
            Console.WriteLine("BaseClass -> Test() method.");
        }

        private void ShowText(string text)
        {
            Console.WriteLine(text);
        }

        #region Abstract methods
        public abstract void ShowTime();
        #endregion
    }
}
