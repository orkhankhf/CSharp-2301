using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Exceptions
{
    public class AgeNotAllowedException : Exception
    {
        public AgeNotAllowedException()
        {
            Console.WriteLine("Custom exception isledi...");
        }
    }
}
