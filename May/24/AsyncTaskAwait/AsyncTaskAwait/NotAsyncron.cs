using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskAwait
{
    public class NotAsyncron
    {
        public Cofee MakeCofee()
        {
            Console.WriteLine("Kofe hazirlanir...");
            Task.Delay(15000).Wait();
            Console.WriteLine("Kofe hazirdir...");
            return new Cofee();
        }

        public Tea MakeTea()
        {
            Console.WriteLine("Cay hazirlanir...");
            Task.Delay(10000).Wait();
            Console.WriteLine("Cay hazirdir...");
            return new Tea();
        }

        public Stake MakeStake()
        {
            Console.WriteLine("Steyk hazirlanir...");
            Task.Delay(30000).Wait();
            Console.WriteLine("Steyk hazirdir...");
            return new Stake();
        }

        public Cheeseburger MakeCheeseburger()
        {
            Console.WriteLine("Cizburger hazirlanir...");
            Task.Delay(20000).Wait();
            Console.WriteLine("Cizburger hazirdir...");
            return new Cheeseburger();
        }
    }
}
