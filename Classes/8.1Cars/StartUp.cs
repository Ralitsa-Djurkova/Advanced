using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._1Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Engine engine = null;

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (engineInfo.Length == 3)
                {
                    int displacement;

                    bool isDisplacement = int.TryParse(engineInfo[2], out displacement);
                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, engineInfo[2]);
                    }

                }
                else if (engineInfo.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                if (engine != null)
                {
                    engines.Add(engine);
                }

            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = null;
                string model = carInfo[0];
                Engine engine = engines.First(e => e.Model == carInfo[1]);

                if (carInfo.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carInfo.Length == 3)
                {
                    double weight;
                    bool isWeight = double.TryParse(carInfo[2], out weight);

                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, carInfo[2]);
                    }
                }
                else if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    car = new Car(model, engine, weight, color);
                }
                if (car != null)
                {
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
