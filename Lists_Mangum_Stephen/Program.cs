using System;
using System.Collections.Generic;

namespace Lists_Mangum_Stephen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a list of game titles
            List<string> games = new List<string>
            {
                "CS:GO",
                "Halo 3",
                "Borderlands 3",
                "Fifa 22",
                "Minecraft",
            };

            // Creates an array of additional game titles
            string[] otherGames = new string[]
            {
                "Tiny Tina's Wonderlands",
                "Farcry 3|"
            };

            // Prints each game in the initial list
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Displays the number of games in the list
            Console.WriteLine($"Games in list: {games.Count}");

            // Adds the otherGames array to the games list
            games.AddRange(otherGames);

            // Displays the updated number of games in the list
            Console.WriteLine($"\n Games in list: {games.Count}");

            // Check if Halo is in the list and prints a message, otherwise add it
            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHIEF BEATS STEVE!!"); // You know this is true... Don't deny the inevitable. Horrifying Houston...
            }
            else
            {
                games.Add("Halo"); // YAY HALO!!! ...I thought angels had those.
            }

            int myInt = 6; // Index to remove from the list. GET IT OUTTA HERE!

            // Removes the game at index myInt if it exists, otherwise print a message
            if (myInt < games.Count)
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGame not found!");
            }

            // Prints all games currently in the list
            Console.WriteLine("\nAll games in the list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Sorts the games list alphabetically
            games.Sort();

            // Prints the sorted games list
            Console.WriteLine("\nSorted games list:");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // Creates a new array and copy the sorted games list into it
            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            // Clears the games list
            games.Clear();

            // Prints the contents of the new array
            Console.WriteLine("\nNew List:");
            foreach (string game in newList)
            {
                Console.WriteLine(game);
            }
        }
    }
}
