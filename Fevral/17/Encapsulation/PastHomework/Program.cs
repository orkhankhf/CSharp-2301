using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Mercedes-Benz", "ML350", 2010, 20000);

            vehicle.BuyPrice = 15000;
            vehicle.SellPrice = 20000;
            vehicle.MaxDiscount = 1500;
            vehicle.SetPrice(20000);
            vehicle.ShowVehicleInfo();

        }
    }
}
