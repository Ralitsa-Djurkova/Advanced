using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] cardata = Console.ReadLine().Split(" ");
                string model = cardata[0];
                double fuelAmount = double.Parse(cardata[1]);
                double fuelConsumptionFor1km = double.Parse(cardata[2]);

                Car currCar = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumptionPerKilometer = fuelConsumptionFor1km
                };
                cars.Add(currCar);

            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandData = command.Split();
                string model = commandData[1];
                double distanceTraveled = double.Parse(commandData[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);

                bool isDrive = car.Drive(distanceTraveled);
                
                if(isDrive == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {(car.FuelAmount):f2} {car.TravelledDistance}");
            }
        }
    }
}
