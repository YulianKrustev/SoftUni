using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] data = Console.ReadLine().Split("-");
                string creator = data[0];
                string teamName = data[1];
                bool isExistingCreator = false;
                bool isExistingTeam = false;

                Team team = new Team(creator, teamName);

                foreach (Team current in teams)
                {
                    if (!isExistingCreator)
                    {
                        isExistingCreator = current.Creator == creator;
                    }

                    if (!isExistingTeam)
                    {
                        isExistingTeam = current.Name == teamName;
                    }

                }

                if (isExistingTeam)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isExistingCreator)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (!isExistingCreator)
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teams.Add(team);
                }
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] data = command.Split("->");
                string memember = data[0];
                string team = data[1];
                bool isExistingTeam = false;
                bool isExistingMemember = false;

                foreach (Team item in teams)
                {
                    if (item.Name == team)
                    {
                        isExistingTeam = true;
                    }


                    if (item.Memebers.Contains(memember) || item.Creator == memember)
                    {
                        isExistingMemember = true;
                    }


                }

                if (!isExistingTeam)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (isExistingMemember)
                {
                    Console.WriteLine($"Member {memember} cannot join team {team}!");
                }
                else
                {
                    foreach (Team item in teams)
                    {
                        if (item.Name == team)
                        {
                            item.Memebers.Add(memember);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            List<Team> disbandTeams = new List<Team>();
            List<Team> bandTeams = new List<Team>();

            foreach (Team item in teams)
            {
                if (item.Memebers.Count == 0)
                {
                    disbandTeams.Add(item);
                }
                else
                {
                    bandTeams.Add(item);
                }
            }

            disbandTeams = disbandTeams.OrderBy(x => x.Name).ToList();
            bandTeams = bandTeams.OrderBy(x => x.Name).ToList();
            bandTeams = bandTeams.OrderByDescending(x => x.Memebers.Count).ToList();
            foreach (Team item in teams)
            {
                item.Memebers.Sort();
            }

            foreach (Team temp in bandTeams)
            {
                Console.WriteLine(temp.Name);
                Console.WriteLine($"- {temp.Creator}");
                for (int i = 0; i < temp.Memebers.Count; i++)
                {
                    Console.WriteLine($"-- {temp.Memebers[i]}");
                }

            }

            Console.WriteLine("Teams to disband:");

            if (disbandTeams.Count != 0)
            {
                foreach (Team item in disbandTeams)
                {
                    Console.WriteLine(item.Name);
                }

            }
        }
    }

    class Team
    {
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;
            Memebers = new List<string>();
        }
        public string Creator { get; set; }
        public List<string> Memebers { get; set; }
        public string Name { get; set; }

    }
}
