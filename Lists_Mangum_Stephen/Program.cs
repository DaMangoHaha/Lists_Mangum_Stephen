using System;
using System.Collections.Generic;

namespace Lists_Mangum_Stephen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            {
                "CS:GO",
                "Halo 3",
                "Borderlands 3",
                "Fifa 22",
                "Minecraft",
            };

            string[] otherGames = new string[]
            {
                "Tiny Tina's Wonderlands",
                "Farcry 3|"
            };

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($"Games in list: {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine($"\n Games in list: {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHIEF BEATS STEVE!!");
            }
            else
            {
                games.Add("Halo");
            }
            int myInt = 6;

            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            games.Sort();

            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("\nNew List:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        } 
    } 
}
