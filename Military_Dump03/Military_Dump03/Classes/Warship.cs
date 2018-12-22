using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Military_Dump03
{
    internal sealed partial class Warship : Vehicle,ISwimmable
    {
        public Warship() { }

        public Warship(string id, int weight, int averageSpeed)
        {
            ID = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = 200;
            Capacity = 50;
        }

        public double FuelTotal { get; set; }

    }
}
