using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    internal sealed class Tank : Vehicle, IDriveable
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

        public override void Print()
        {
            var format = $"ID: {ID},\n" +
                         $"Weight: {Weight},\n" +
                         $"Avg. Speed: {AverageSpeed},\n" +
                         $"Fuel Consumption: {FuelConsumption},\n" +
                         $"Capacity: {Capacity},\n" +
                         $"Total fuel consumption:  \n";

            Console.WriteLine(format);
        }

        public int Move(Distance distance)
        {
            var simulation = 0;
            var destination = distance.Total;
          
            var rnd = new Random();

            var checkPoint = 10;

            for (var km = 0; km < destination; km++)
            {
                if (km == checkPoint)
                {
                    var rand = rnd.Next(1, 101);
                    if (rand <= 33)
                    {
                        destination += 5;
                    }

                    checkPoint += 10;
                }

                km += 1;
                simulation = km;
            }

            return simulation;

        }

        public int TripSimulation(int moveDirection, int people)
        {
            var trips = 0;
            if (people < Capacity)
            {
                trips = 1;
            }

            else if (people > Capacity && people % Capacity == 0)
            {
                trips = 2 * (people / Capacity) - 1;
            }

            else
            {
                trips = 2 * (people / Capacity + 1) - 1;
            }

            return trips * moveDirection;
        }
    }
}
