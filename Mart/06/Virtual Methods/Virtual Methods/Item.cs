using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    public class Item : BaseClass
    {
        public override void ShowText(string text)
        {
            //base.ShowText(text);
            Console.WriteLine("Item => " + text);
        }
    }
}
