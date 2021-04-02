using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> database = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> final = new Dictionary<string, Dictionary<string, int>>();


            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] data = input.Split(" -> ");
                    string player = data[0];
                    string position = data[1];
                    int skill = int.Parse(data[2]);

                    if (database.ContainsKey(position) == false)
                    {
                        database.Add(position, new Dictionary<string, int>());
                        database[position].Add(player, skill);
                    }
                    else if (database[position].ContainsKey(player) && database[position][player] < skill)
                    {
                        database[position][player] = skill;
                    }
                    else if (database[position].ContainsKey(player) == false)
                    {
                        database[position].Add(player, skill);
                    }

                    if (final.ContainsKey(player) == false)
                    {
                        final.Add(player, new Dictionary<string, int>());
                        final[player].Add(position, skill);
                    }
                    else if (final[player].ContainsKey(position) && final[player][position] < skill)
                    {
                        final[player][position] = skill;
                    }
                    else if (final[player].ContainsKey(position) == false)
                    {
                        final[player].Add(position, skill);
                    }
                }
                else
                {
                    string[] data = input.Split(" vs ");
                    string playerOne = data[0];
                    string playerTwo = data[1];
                    string battlePosition = string.Empty;

                    bool workIt = false;

                    foreach (var position in database)
                    {
                        if (position.Value.ContainsKey(playerOne) && position.Value.ContainsKey(playerTwo))
                        {
                            battlePosition = position.Key;
                            workIt = true;
                        }

                    }

                    if (workIt)
                    {
                        if (database[battlePosition][playerOne] > database[battlePosition][playerTwo])
                        {
                            database[battlePosition].Remove(playerTwo);
                            final.Remove(playerTwo);
                        }
                        else if (database[battlePosition][playerOne] < database[battlePosition][playerTwo])
                        {
                            database[battlePosition].Remove(playerOne);
                            final.Remove(playerOne);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in final.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
