using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    public sealed class Warship : Vehicle,ISwimmable
    {
        public Warship(int id, int weight, int averageSpeed)
        {
            ID = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = 200;
            Capacity = 50;
        }
    }
}
