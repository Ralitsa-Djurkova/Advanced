using System;
using System.Collections.Generic;
namespace _06._ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parke = new HashSet<string>();
            while (input != "END")
            {
                string[] tokens = input.Split(", ");
                string direction = tokens[0];
                string carName = tokens[1];
                if(direction == "IN")
                {
                    parke.Add(carName);
                }
                else if(direction == "OUT")
                {
                    parke.Remove(carName);
                }
              
                input = Console.ReadLine();
            }
            if (parke.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            foreach (var item in parke)
            {
                
                Console.WriteLine(item);
            }
            
        }
    }
}
