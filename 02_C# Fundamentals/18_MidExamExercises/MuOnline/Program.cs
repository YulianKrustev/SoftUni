using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int health = 100;
            int bitcoins = 0;
            int roomsCounter = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentCmd = rooms[i].Split();
                roomsCounter++;

                switch (currentCmd[0].ToUpper())
                {
                    case "POTION":
                        if (health + int.Parse(currentCmd[1]) > 100)
                        {
                            currentCmd[1] = (100 - health).ToString();
                        }
                        health += int.Parse(currentCmd[1]);
                        Console.WriteLine($"You healed for {currentCmd[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;

                    case "CHEST":
                        Console.WriteLine($"You found {currentCmd[1]} bitcoins.");
                        bitcoins += int.Parse(currentCmd[1]);
                        break;

                    default:

                        if (health - int.Parse(currentCmd[1]) > 0)
                        {
                            Console.WriteLine($"You slayed {currentCmd[0]}.");
                            health -= int.Parse(currentCmd[1]);
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {currentCmd[0]}.");
                            Console.WriteLine($"Best room: {roomsCounter}");
                            return;
                        }
                        break;
                }
            }

            if (rooms.Length == roomsCounter)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
