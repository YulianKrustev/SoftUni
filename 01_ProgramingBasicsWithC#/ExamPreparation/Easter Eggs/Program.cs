using System;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());
            int redEgg = 0;
            int orangeEgg = 0;
            int blueEgg = 0;
            int greenEgg = 0;

            for (int egg = 1; egg <= paintedEggs; egg++)
            {
                string currentEgg = Console.ReadLine();

                switch (currentEgg)
                {
                    case "red":
                        redEgg++;
                        break;
                    case "orange":
                        orangeEgg++;
                        break;
                    case "blue":
                        blueEgg++;
                        break;
                    case "green":
                        greenEgg++;
                        break;
                }
            }
            Console.WriteLine($"Red eggs: {redEgg}");
            Console.WriteLine($"Orange eggs: {orangeEgg}");
            Console.WriteLine($"Blue eggs: {blueEgg}");
            Console.WriteLine($"Green eggs: {greenEgg}");
            if (redEgg > orangeEgg && redEgg > blueEgg && redEgg > greenEgg)
            {
                Console.WriteLine($"Max eggs: {redEgg} -> red");
            }
            else if (orangeEgg > redEgg && orangeEgg > blueEgg && orangeEgg > greenEgg)
            {
                Console.WriteLine($"Max eggs: {orangeEgg} -> orange");
            }
            else if (blueEgg > redEgg && blueEgg > orangeEgg && blueEgg > greenEgg)
            {
                Console.WriteLine($"Max eggs: {blueEgg} -> blue");
            }
            else if (greenEgg> redEgg && greenEgg > orangeEgg && greenEgg > blueEgg)
            {
                Console.WriteLine($"Max eggs: {greenEgg} -> green");
            }
        }
    }
}
