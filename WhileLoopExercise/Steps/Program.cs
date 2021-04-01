using System;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumSteps = 0;

            while (sumSteps < 10000)
            {
                string currentSteps = Console.ReadLine();

                if (currentSteps == "Going home")
                {
                    sumSteps += int.Parse(Console.ReadLine());
                    break;
                }
                sumSteps += int.Parse(currentSteps);
            }

            if (sumSteps > 10000)
            {
                Console.WriteLine($"Goal reached! Good job!\n{sumSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
            }
        }
    }
}
