using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    internal sealed partial class Amfibia : Vehicle,IDriveable,ISwimmable
    {
        public Amfibia() { }

        public Amfibia(string id, int weight, int averageSpeed) 
        {
            ID = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = 70;
            Capacity = 20;
        }

        public double FuelTotal { get; set; }

    }
}
