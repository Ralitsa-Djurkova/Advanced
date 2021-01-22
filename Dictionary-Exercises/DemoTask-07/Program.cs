using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoTask_07
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Vlogger> vloggers = new HashSet<Vlogger>();
            var input = Console.ReadLine().Split().ToArray();

            while (input[0] != "Statistics")
            {
                switch (input[1])
                {
                    case "joined":

                        Vlogger newVloger = new Vlogger(input[0]);
                        if (!vloggers.Any(v => v.Name == newVloger.Name))
                        {
                            vloggers.Add(newVloger);
                        }

                        break;
                    case "followed":
                        //Safrona followed EmilConrad
                        var following = input[0];//Safrona
                        var followerd = input[2];//EmilConrad

                        if (followerd != following && vloggers.Any(v=>v.Name == following) && vloggers.Any(v=>v.Name == followerd))
                        {
                            Vlogger vlogger1 = (Vlogger)vloggers.Where(v => v.Name == following).FirstOrDefault();
                            vlogger1.AddFollowing(followerd);

                            Vlogger vlogger2 = (Vlogger)vloggers.Where(v => v.Name == followerd).FirstOrDefault();
                            vlogger2.AddFollower(following);
                        }
                        break;
                }
                input = Console.ReadLine().Split().ToArray();
            }

            int maxFollowers = int.MinValue;
            foreach (var item in vloggers)
            {
                if (item.Followers.Count > maxFollowers)
                {
                    maxFollowers = item.Followers.Count;
                }
            }
            Vlogger famous = vloggers.Where(v => v.Followers.Count == maxFollowers).FirstOrDefault();
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            Console.WriteLine($"1. {famous.Name} : {famous.Followers.Count} followers, {famous.Following.Count} following");

            foreach (var follower in famous.Followers)
            {
                Console.WriteLine($"*  {follower}");
            }

            vloggers.Remove(famous);

            var sorted = vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Following.Count);
            int counter = 2;
            foreach (var item in sorted)
            {
                Console.WriteLine($"{counter}. {item.Name} : {item.Followers.Count} followers, {item.Following.Count} following");
                counter++;
            }
        }

    }

    public class Vlogger
    {

        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }

        public Vlogger(string name)
        {
            this.Name = name;
            this.Followers = new SortedSet<string>();
            this.Following = new HashSet<string>();
        }
        public void AddFollower(string name)
        {
            Followers.Add(name);
        }

        public void AddFollowing(string name)
        {
            Following.Add(name);
        }
    }


}
