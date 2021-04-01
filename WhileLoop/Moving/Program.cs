using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length= int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            string boxes = Console.ReadLine();
            int emptySpace = width * length * hight;

            while (boxes != "Done")
            {
                int currentBoxes = int.Parse(boxes);
                emptySpace -= currentBoxes;
                if (emptySpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(emptySpace)} Cubic meters more.");
                    break;
                }
                boxes = Console.ReadLine();
            }

            if (boxes == "Done")
            {
                Console.WriteLine($"{emptySpace} Cubic meters left.");
            }

        }
    }
}
