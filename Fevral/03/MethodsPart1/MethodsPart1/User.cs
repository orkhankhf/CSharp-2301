using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    public class User
    {
        public void Login(string username, string password)
        {
            //Database'den username ve password'un dogrulugu yoxlanildi...
            Console.WriteLine("User daxil oldu: " + username);
        }

        public void Registration(string username)
        {
            //Yeni user'in melumatlari database'e elave edildi
            Console.WriteLine(username + " qeydiyyatdan kecdi.");
        }
    }
}
