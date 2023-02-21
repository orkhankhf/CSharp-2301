using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class EmailHelper
    {
        public static void SendWelcomeMail(string receiver)
        {
            Console.WriteLine("Bu methodda xos geldiniz emaili gonderilir...");
        }

        public static void SendPasswordChangeMail(string receiver)
        {
            Console.WriteLine("Bu methodda sifre deyisdi emaili gonderilir...");
        }
    }
}
