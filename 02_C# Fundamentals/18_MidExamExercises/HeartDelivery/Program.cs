using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("@");
            string[] command = Console.ReadLine().Split();
            int[] houses = input.Select(int.Parse).ToArray();
            int position = 0;

            while (command[0] != "Love!")
            {               
                int index = int.Parse(command[1]);

                if (index < 0 || index + position >= houses.Length)
                {
                    position = 0;
                    if (houses[0] - 2 >= 2)
                    {
                        houses[0] -= 2;
                    }
                    else if (houses[0] - 2 == 0)
                    {
                        houses[0] -= 2;
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                    else
                    {
                        Console.WriteLine($"Place {position} already had Valentine's day.");
                    }
                }
                else
                {
                    position += index;

                    if (houses[position] - 2 >= 2)
                    {
                        houses[position] -= 2;
                    }
                    else if (houses[position] - 2 == 0)
                    {
                        houses[position] -= 2;
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                    else
                    {
                        Console.WriteLine($"Place {position} already had Valentine's day.");
                    }
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {position}.");
            int houseCount = 0;

            if (houses.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                for (int i = 0; i < houses.Length; i++)
                {
                    if (houses[i] != 0)
                    {
                        houseCount++;
                    }
                }
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}
