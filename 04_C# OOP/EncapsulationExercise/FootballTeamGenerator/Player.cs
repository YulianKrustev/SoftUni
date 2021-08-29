using System;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int minStatsValue = 0;
        private const int maxStatsValue = 100;
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int shooting;
        private int passing;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name 
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                    return;
                }

                name = value;
            }
        }   

        private int Endurance 
        {
            set
            {
                if (value < minStatsValue || value > maxStatsValue)
                {
                    throw new ArgumentException($"Endurance should be between 0 and 100.");
                    return;
                }

                endurance = value;
            }
        }

        private int Sprint
        {
            set
            {
                if (value < minStatsValue || value > maxStatsValue)
                {
                    throw new ArgumentException($"Sprint should be between 0 and 100.");
                }

                sprint = value;
            }
        }

        private int Dribble
        {
            set
            {
                if (value < minStatsValue || value > maxStatsValue)
                {
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                }

                dribble = value;
            }
        }

        private int Passing
        {
            set
            {
                if (value < minStatsValue || value > maxStatsValue)
                {
                    throw new ArgumentException($"Passing should be between 0 and 100.");
                }

                passing = value;
            }
        }

        private int Shooting
        {
            set
            {
                if (value < minStatsValue || value > maxStatsValue)
                {
                    throw new ArgumentException($"Shooting should be between 0 and 100.");
                }

                shooting = value;
            }
        }

        public int Stats => (int)Math.Round((endurance + sprint + dribble + shooting + passing) / (double)5);
    }
}
