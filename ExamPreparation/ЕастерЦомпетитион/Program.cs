using System;

namespace ЕастерЦомпетитион
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSweetBread = int.Parse(Console.ReadLine());
            int totalPoints = int.MinValue;
            string winner = "";
            for (int i = 0; i < numSweetBread; i++)
            {
                string chef = Console.ReadLine();
                string pointsAsText = Console.ReadLine();
                int currentPoints = 0;
                while (pointsAsText != "Stop")
                {
                    currentPoints += int.Parse(pointsAsText);
                    pointsAsText = Console.ReadLine();
                }
                if (pointsAsText == "Stop")
                {
                    if (currentPoints > totalPoints)
                    {
                        winner = chef;
                        totalPoints = currentPoints;
                        Console.WriteLine($"{chef} has {currentPoints} points.");
                        Console.WriteLine($"{chef} is the new number 1!");
                    }
                    else
                    {
                        Console.WriteLine($"{chef} has {currentPoints} points.");
                    }   
                }            
            }
            Console.WriteLine($"{winner} won competition with {totalPoints} points!");
        }
    }
}
