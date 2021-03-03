using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(" ");

                string model = inputInfo[0];
                int engineSpeed = int.Parse(inputInfo[1]);
                int enginePower = int.Parse(inputInfo[2]);

                int cargoWeght = int.Parse(inputInfo[3]);
                string cargoTypeCommand = inputInfo[4];

                Tire[] tires = new Tire[4];
                int counter = 0;
                for (int tireIndex = 5; tireIndex < inputInfo.Length; tireIndex+=2)
                {
                    double currTirePressure = double.Parse(inputInfo[tireIndex]);
                    int currTireAge = int.Parse(inputInfo[tireIndex + 1]);

                    Tire tire = new Tire(currTirePressure, currTireAge);
                    tires[counter++] = tire;
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeght, cargoTypeCommand);
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }
            string cargoType = Console.ReadLine();
            if(cargoType == "flamable")
            {
                cars.Where(x => x.Engine.EnginePower > 250 && x.Cargo.CargoType == "flamable")
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
            else if(cargoType == "fragile")
            {
                cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(p => p.TirePressure < 1))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}
