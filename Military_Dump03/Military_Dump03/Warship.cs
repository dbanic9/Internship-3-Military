using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Military_Dump03
{
    internal sealed class Warship : Vehicle,ISwimmable
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

        public int Swim(Distance distance)
        {
            var simulation = 0;
            var destination = distance.Total;

            var rnd = new Random();

            var everyTenMin = Math.Round(AverageSpeed * 0.17);
            var checkPoint = everyTenMin;

            for (var km = 0; km < destination; km++)
            {
                if (km == checkPoint)
                {
                    var rand = rnd.Next(1, 101);
                    if (rand <= 50)
                    {
                        destination += 3;
                    }

                    checkPoint += everyTenMin;
                }

                km += 1;
                simulation = km;
            }

            return simulation;
            
        }


    }
}
