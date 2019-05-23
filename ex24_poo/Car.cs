using System;
using System.Collections.Generic;
using System.Text;

namespace ex24_poo
{
    public class Car : Vehicle
    {
        private Passenger[] passengers;

        public Car(double value, int numPassengers, float avgWeight) : base(value)
        {
            Random r = new Random();
            passengers = new Passenger[numPassengers];
            for (int i = 0; i < numPassengers; i++)
            {
                passengers[i] = new Passenger()
                {
                    Weight = avgWeight + r.Next(-10, 10)
                };
            }
        }

        public double GetTotalWeight(Car car)
        {
            double totalWeight = 0;
            foreach (Passenger p in passengers) totalWeight += p.Weight;
            return totalWeight;
        }
    }
}
