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

           tank.StartTrip();
           tank.Print();
            
        }
    }
}
