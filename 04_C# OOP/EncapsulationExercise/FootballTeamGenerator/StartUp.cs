using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (tokens[0] == "Team")
                    {
                        Team team = new Team(tokens[1]);
                        teams.Add(team);
                    }
                    else if (tokens[0] == "Add")
                    {
                        bool isFound = false;

                        foreach (Team team in teams)
                        {
                            if (team.Name == tokens[1])
                            {
                                string playerName = tokens[2];

                                int endurance = int.Parse(tokens[3]);
                                int sprint = int.Parse(tokens[4]);
                                int dribble = int.Parse(tokens[5]);
                                int passing = int.Parse(tokens[6]);
                                int shoting = int.Parse(tokens[7]);

                                Player player = new Player(playerName, endurance, sprint, dribble, passing, shoting);
                                team.AddPlayer(player);

                                isFound = true;

                                break;
                            }
                        }

                        if (isFound == false)
                        {
                            throw new ArgumentException($"Team {tokens[1]} does not exist.");
                        }
                    }
                    else if (tokens[0] == "Remove")
                    {
                        string teamName = tokens[1];
                        string playerName = tokens[2];
                        bool isFound = false;

                        foreach (Team team in teams)
                        {
                            if (team.Name == teamName && team.Players.Any(x => x.Name == playerName))
                            {
                                Player currentPlayer = team.Players.First(x => x.Name == playerName);
                                isFound = team.RemovePLayer(currentPlayer);
                                break;
                            }
                        }

                        if (isFound == false)
                        {
                            throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
                        }

                    }
                    else if (tokens[0] == "Rating")
                    {
                        string teamName = tokens[1];
                        bool isFound = false;

                        foreach (Team team in teams)
                        {
                            if (team.Name == teamName)
                            {
                                isFound = true;
                                Console.WriteLine($"{teamName} - {team.Rating}");
                                break;
                            }
                        }

                        if (isFound == false)
                        {
                            throw new Exception($"Team {teamName} does not exist.");
                        }
                    }

                    command = Console.ReadLine();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    command = Console.ReadLine();
                }
            }
        }
    }
}
