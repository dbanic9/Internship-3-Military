using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    internal partial class Tank
    {
        public override void Print()
        {
            var format = $"ID: {ID},\n" +
                         $"Weight: {Weight},\n" +
                         $"Avg. Speed: {AverageSpeed},\n" +
                         $"Fuel Consumption: {FuelConsumption},\n" +
                         $"Capacity: {Capacity},\n" +
                         $"Total fuel consumption: {FuelTotal}L \n";

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
            return 0.3 * simulationDistance;
        }

        public void StartTrip()
        {
            Console.WriteLine("Enter tank distance:");
            var distance = new Distance(int.Parse(Console.ReadLine()), 0);
            Console.WriteLine("Enter the number of people:");
            var people = int.Parse(Console.ReadLine());
            var move = Move(distance);
            var trip = TripSimulation(move, people);
            FuelTotal = TotalFuelPerTrip(trip);
        }
    }
}
