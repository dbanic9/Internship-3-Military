using System;

namespace Military_Dump03
{
    class Program
    {
        static void Main(string[] args)
        {
            var amfibia = new Amfibia(1, 30000, 25);
            var warship = new Warship(1, 35000, 50);
            var tank = new Tank(1, 57000, 30);
        }
    }
}
