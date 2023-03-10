using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    public partial class Car : BaseClass<Car>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; }
        public string SeatMaterial { get; set; }
        public int DoorCount { get; set; }
        public int Engine { get; set; }
        public string FuelType { get; set; }

        public override int Add(Car item)
        {
            return 1;
        }

        public override bool Delete(int id)
        {
            return true;
        }

        public override Car Get(int id)
        {
            return new Car();
        }

        public override Car[] GetAll()
        {
            return new Car[10];
        }

        public override Car Update(Car item)
        {
            return new Car();
        }
    }
}
