using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskAwait
{
    public class Cofee { }
    public class Tea { }
    public class Stake { }
    public class Cheeseburger { }

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            MakeOrder();

            stopWatch.Stop();
            Console.WriteLine("Duration for not asyncron method:" + stopWatch.Elapsed);

            stopWatch.Reset();

            stopWatch.Start();

            MakeOrderAsync().Wait();

            stopWatch.Stop();

            Console.WriteLine("Duration for asyncron method:" + stopWatch.Elapsed);
        }

        public static void MakeOrder()
        {
            NotAsyncron order = new NotAsyncron();
            order.MakeCofee();
            order.MakeTea();
            order.MakeStake();
            order.MakeCheeseburger();
        }

        public static async Task MakeOrderAsync()
        {
            Asyncron order = new Asyncron();
            await Task.WhenAll(
                order.MakeCofee(),
                order.MakeTea(),
                order.MakeStake(),
                order.MakeCheeseburger());
        }
    }
}
