using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countKegs = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string winner = string.Empty;
            for (int i = 0; i < countKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentKeg = (Math.PI * (radius * radius) * height);
                if (currentKeg > biggestKeg)
                {
                    biggestKeg = currentKeg;
                    winner = model;
                }
            }
            Console.WriteLine(winner);
        }
    }
}
