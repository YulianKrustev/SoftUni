using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();
            string typeOfShot = Console.ReadLine();
            int remainingPoints = 0;
            int successShots = 0;
            int unSuccessShots = 0;
            while (typeOfShot != "Retire")
            {
                int points = int.Parse(Console.ReadLine());
                if (typeOfShot == "Single")
                {
                    points *= 1;
                }
                else if (typeOfShot == "Double")
                {
                    points *= 2;
                }
                else if (typeOfShot == "Triple")
                {
                    points *= 3;
                }
                remainingPoints += points;
                if (remainingPoints < 301)
                {
                    
                    successShots++;
                }
                else if (remainingPoints > 301)
                {
                    unSuccessShots++;
                    remainingPoints -= points;
                }
                if (remainingPoints == 301)
                {
                    successShots++;
                    Console.WriteLine($"{nameOfPlayer} won the leg with {successShots} shots.");
                    break;
                }
                typeOfShot = Console.ReadLine();
            }
            if (typeOfShot == "Retire")
            {
                Console.WriteLine($"{nameOfPlayer} retired after {unSuccessShots} unsuccessful shots.");
            }
        }
    }
}
