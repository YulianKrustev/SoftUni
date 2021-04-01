using System;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeToShoot = int.Parse(Console.ReadLine());
            int sceneCount = int.Parse(Console.ReadLine());
            int timeForScene = int.Parse(Console.ReadLine());
            double scenePreparing = timeToShoot * 0.15;
            double timeForMovie = timeToShoot - scenePreparing - (sceneCount * timeForScene);

            if (timeForMovie >= 0)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForMovie)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeForMovie*-1)} minutes.");
            }

            
        }
    }
}
