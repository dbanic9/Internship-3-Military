using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    public abstract class Vehicle
    {
        public string ID { get; set; }
        public int Weight { get; set; }
        public int AverageSpeed { get; set; }
        public int FuelConsumption { get; set; }
        public int Capacity { get; set; }

        public virtual void Print()
        {
            var format = $"ID: {ID},\n" +
                        $"Weight: {Weight},\n" +
                        $"Avg. Speed: {AverageSpeed},\n" +
                        $"Fuel Consumption: {FuelConsumption},\n" +
                        $"Capacity: {Capacity},\n";
            Console.WriteLine(format);
        }

    }
}
