using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public List<Player> players;
        int count;
        public Guild(string name, int capacity)
        {
            players = new List<Player>(capacity);
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get { return players.Count; }
        }


        public void AddPlayer(Player player)
        {
            if (players.Count < Capacity)
            {
                players.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            bool isExist = false;

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name == name)
                {
                    isExist = true;
                    players.RemoveAt(i);
                    break;
                }
            }

            return isExist;
        }

        public void PromotePlayer(string name)
        {
            foreach (Player player in players)
            {
                if (player.Name == name)
                {
                    player.Rank = "Member";
                    break;
                }
            }
        }

        public void DemotePlayer(string name)
        {
            foreach (Player player in players)
            {
                if (player.Name == name)
                {
                    player.Rank = "Trial";
                    break;
                }
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> removed = new List<Player>();

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Class == @class)
                {
                    removed.Add(players[i]);
                    players.RemoveAt(i);
                    i--;
                }
            }

            return removed.ToArray();
        }
            
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {this.Name}");

            foreach (Player player in players)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
