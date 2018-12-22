using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    internal partial class Warship
    {
        public override void Print()
        {
            var format = $"ID: {ID},\n" +
                         $"Weight: {Weight},\n" +
                         $"Avg. Speed: {AverageSpeed},\n" +
                         $"Fuel Consumption: {FuelConsumption},\n" +
                         $"Capacity: {Capacity},\n" +
                         $"Total fuel consumption: {FuelTotal}L  \n";

            Console.WriteLine(format);
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
                simulation = km;
            }

            return simulation;

        }

        private int TripSimulation(int moveDirection, int people)
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

        private double TotalFuelPerTrip(int simulationDistance)
        {
            return 2 * simulationDistance;
        }

        public void StartTrip()
        {
            Console.WriteLine("Enter warship distance:");
            var distance = new Distance(0, int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the number of people:");
            var people = int.Parse(Console.ReadLine());
            var swim = Swim(distance);
            var trip = TripSimulation(swim, people);
            FuelTotal = TotalFuelPerTrip(trip);

        }
    }
}
