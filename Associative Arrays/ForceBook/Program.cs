using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, List<string>> forcebook = new SortedDictionary<string, List<string>>();
            List<string> usersList = new List<string>();

            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] cmd = input.Split(" | ");
                    string forceSide = cmd[0];
                    string forceUser = cmd[1];

                    if (usersList.Contains(forceUser) == false)
                    {
                        usersList.Add(forceUser);

                        if (forcebook.ContainsKey(forceSide) == false)
                        {
                            forcebook.Add(forceSide, new List<string>());
                        }

                        forcebook[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    string[] cmd = input.Split(" -> ");
                    string forceUser = cmd[0];
                    string forceSide = cmd[1];

                    if (usersList.Contains(forceUser))
                    {
                        foreach (var side in forcebook)
                        {
                            for (int i = 0; i < side.Value.Count; i++)
                            {
                                if (side.Value.Contains(forceUser))
                                {
                                    side.Value.Remove(forceUser);
                                }
                            }
                        }
                    }

                    if (forcebook.ContainsKey(forceSide))
                    {
                        forcebook[forceSide].Add(forceUser);
                    }
                    else
                    {
                        forcebook.Add(forceSide, new List<string> { forceUser });
                    }
                    
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                input = Console.ReadLine();
            }

            foreach (var item in forcebook.OrderByDescending(user => user.Value.Count))
            {
                if (item.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                }

                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
