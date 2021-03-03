using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._1
{
    public class StartUp
    {
       public static void Main(string[] args)
       {
            string command = Console.ReadLine();

            Dictionary<string, Trainer> traners = new Dictionary<string, Trainer>();
            while (command != "Tournament")
            {
                string[] cmdArg = command.Split().ToArray();
                string nameTraner = cmdArg[0];
                string pokemonName = cmdArg[1];
                string pokemonElement = cmdArg[2];
                int pokemonHealth = int.Parse(cmdArg[3]);

                if (!traners.ContainsKey(nameTraner))
                {
                    traners.Add(nameTraner, new Trainer(nameTraner));
                }
                Trainer currenttraner = traners[nameTraner];
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                currenttraner.Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string element = command;

                foreach (var traner in traners)
                {
                    if (traner.Value.Pokemons.Any(p => p.Element == element))
                    {
                        traner.Value.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var item in traner.Value.Pokemons)
                        {
                            item.Health -= 10;
                        }
                        traner.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
                command = Console.ReadLine();
            }

            var result = traners.OrderByDescending(x => x.Value.NumberOfBadges).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} {item.Value.NumberOfBadges} {item.Value.Pokemons.Count()}");
            }
        }
    }
}
