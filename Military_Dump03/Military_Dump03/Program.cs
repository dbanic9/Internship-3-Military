using System;
using System.Security.Cryptography.X509Certificates;

namespace Military_Dump03
{
    class Program
    {
        static void Main(string[] args)
        {
            var amfibia = new Amfibia("Amfibia", 30000, 25);
            var warship = new Warship("Warship", 35000, 50);
            var tank = new Tank("Tank", 57000, 30);


            amfibia.StartTrip();
            warship.StartTrip();
            tank.StartTrip();

            Console.WriteLine("\n");
            Console.WriteLine("Best vehicle choice:\n");

            if (amfibia.FuelTotal < warship.FuelTotal && amfibia.FuelTotal < tank.FuelTotal)
            {
                amfibia.Print();
            }
            else if (warship.FuelTotal < amfibia.FuelTotal && warship.FuelTotal < tank.FuelTotal)
            {
                warship.Print();
            }
            else if (tank.FuelTotal < amfibia.FuelTotal && tank.FuelTotal < warship.FuelTotal)
            {
                tank.Print();
            }
            
        }
    }
}
