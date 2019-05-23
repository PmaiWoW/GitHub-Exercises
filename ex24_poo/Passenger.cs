using System;
using System.Collections.Generic;
using System.Text;

namespace ex24_poo
{
    public struct Passenger
    {
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { if (value < 5) weight = 5; else weight = value; }
        }
    }
}
