using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Dump03
{
    public sealed class Distance
    {
        public int Land { get; set; }
        public int Water { get; set; }
        public int Total { get; set; }

        public Distance(int land,int water)
        {
            Land = land;
            Water = water;
            Total = land + water;
        }
    }
}
