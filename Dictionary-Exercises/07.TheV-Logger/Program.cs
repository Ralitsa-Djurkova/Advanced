using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            //app.Add(" ", new Dictionary<string, SortedSet<string>>());
            //app["User one"].Add("following", new SortedSet<string>());
            //app["User one"].Add("followers", new SortedSet<string>());
            string commandInput = Console.ReadLine();

            while (commandInput != "Statistics")
            {
                string[] commandData = commandInput.Split(" ");
                string vlogerName = commandData[0];
                string command = commandData[1];


                if (command == "joined")
                {
                    if (!app.ContainsKey(vlogerName))
                    {
                        app.Add(vlogerName, new Dictionary<string, SortedSet<string>>());
                        app[vlogerName].Add("following", new SortedSet<string>());
                        app[vlogerName].Add("followers", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string vloggerTwoName = commandData[2];
                    if (app.ContainsKey(vlogerName) && app.ContainsKey(vloggerTwoName) && vlogerName != vloggerTwoName)
                    {
                        app[vlogerName]["following"].Add(vloggerTwoName);
                        app[vloggerTwoName]["following"].Add(vlogerName);
                    }
                }
                commandInput = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, SortedSet<string>>> sortedDataApp =
           app.OrderByDescending(kvp => kvp.Value["following"].Count).ThenBy(x => x.Value["following"].Count)
           .ToDictionary(x => x.Key, x => x.Value);
            int counter = 1;
            foreach (KeyValuePair<string, Dictionary<string, SortedSet<string>>> item in sortedDataApp)
            {
                int followersCount = item.Value["following"].Count();
                int followingCount = item.Value["followed"].Count();
                Console.WriteLine($"{++counter}. {item.Key} : {followersCount} followers, {followingCount} following");

                if (counter == 1)
                {
                    foreach (string follower in item.Value["followers"])
                    {
                        Console.WriteLine($"* {follower}");
                    }
                }
            }
        }
    }
}
