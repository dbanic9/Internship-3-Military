using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    public sealed class Amfibia : Vehicle,IDriveable,ISwimmable
    {
        public Amfibia(int id, int weight, int averageSpeed) 
        {
            ID = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = 70;
            Capacity = 20;
        }
    }
}
