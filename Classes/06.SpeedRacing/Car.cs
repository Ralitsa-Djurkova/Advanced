using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTraveled)
        {
            double neededFued = distanceTraveled * this.FuelConsumptionPerKilometer;

            if(neededFued > this.FuelAmount)
            {
                return false;
            }

            this.FuelAmount -= neededFued;
            this.TravelledDistance += distanceTraveled;
            return true;
        }
    }
}
