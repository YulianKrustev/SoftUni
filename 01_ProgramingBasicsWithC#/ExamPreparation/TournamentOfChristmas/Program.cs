using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDuration = int.Parse(Console.ReadLine());
            double totalMoney = 0;
            int totalWins = 0;
            int totalLoose = 0;
            for (int i = 0; i < tournamentDuration; i++)
            {
                string typeOfSport = Console.ReadLine();
                double currnetDayMoney = 0;
                int counterDailyWin = 0;
                while (typeOfSport != "Finish")
                {
                    string condition = Console.ReadLine();
                    if (condition == "win")
                    {
                        counterDailyWin++;
                        currnetDayMoney += 20;
                        
                    }
                    else
                    {
                        counterDailyWin--;
                    }
                    typeOfSport = Console.ReadLine();
                }
                if (counterDailyWin > 0)
                {
                    currnetDayMoney += currnetDayMoney * 0.1;
                    totalMoney += currnetDayMoney;
                    totalWins++;
                }
                else
                {
                    totalMoney += currnetDayMoney;
                    totalLoose++;
                }
            }
            if (totalWins > totalLoose)
            {
                totalMoney += totalMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
