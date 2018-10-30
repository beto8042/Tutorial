using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckCards
{
    public abstract class Vehicle
    {
        public int Wheels { get; set; }

        public int Seats { get; set; }
    }

    public class Car : Vehicle
    {
        public string MotorModel { get; set; }
    }

    public class Bycicle : Vehicle
    {
        public string Material { get; set; }
    }


}
