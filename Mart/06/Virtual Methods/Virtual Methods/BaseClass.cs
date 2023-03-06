using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    public class BaseClass
    {
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public virtual void ShowText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
