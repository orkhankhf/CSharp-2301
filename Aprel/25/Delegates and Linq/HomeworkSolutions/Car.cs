using HomeworkSolutions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSolutions
{
    public class Car
    {
        public int Id { get; set; }
        public string City { get; set; } //Şəhər
        public string Brand { get; set; } //Marka
        public string Model { get; set; } //Model
        public int Year { get; set; } //Buraxılış ili
        public ColorEnum Color { get; set; } //Rəngi
        public int Engine { get; set; } //Mühərrik Həcmi
        public int HP { get; set; } //At Gücü / Horse Power
        public decimal Km { get; set; } //Kilometrajı
        public GearboxTypeEnum GearboxType { get; set; } //Sürətlər Qutusunun tipi
        public decimal Price { get; set; } //Qiyməti
    }
}
