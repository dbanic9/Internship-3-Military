using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    public abstract class Vehicle
    {
        public int ID { get; set; }
        public int Weight { get; set; }
        public int AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

    }
}
