using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    internal sealed partial class Tank : Vehicle, IDriveable
    {
        public Tank()
        {
        }

        public Tank(string id, int weight, int averageSpeed)
        {
            ID = id;
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = 30;
            Capacity = 6;
        }

        public double FuelTotal { get; set; }

    }
}
