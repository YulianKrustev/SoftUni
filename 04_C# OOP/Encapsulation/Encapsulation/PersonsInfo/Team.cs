using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name => this.name;

        public IReadOnlyList<Person> FirstTeam => this.firstTeam.AsReadOnly();
        public IReadOnlyList<Person> ReserveTeam => this.reserveTeam.AsReadOnly();

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }

    }
}
