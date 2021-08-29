using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public int Rating 
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return players.Sum(x => x.Stats) / players.Count;
                }
            }
        }

        public IList<Player> Players => players.AsReadOnly();

        public bool AddPlayer(Player player)
        {
            players.Add(player);
            return true;
        }

        public bool RemovePLayer(Player player)
        {
            if (players.Contains(player) == false)
            {
                throw new ArgumentException($"Player {player.Name} is not in {name} team.");
            }

            players.Remove(player);

            return true;
        }
    }
}
