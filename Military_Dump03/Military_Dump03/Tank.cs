using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    public sealed class Tank : Vehicle,IDriveable
    {
        public Tank(int id, int weight, int averageSpeed)
        {
            ID = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = 30;
            Capacity = 6;
        }
    }
}
