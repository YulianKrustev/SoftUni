using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int value = int.Parse(Console.ReadLine());

            Stack<int> listOfBullets = new Stack<int>(bullets);
            Queue<int> listOfLocks = new Queue<int>(locks);

            int bulletCounter = 0;
            int counter = 0;

            while (listOfBullets.Any() && listOfLocks.Any())
            {
                bulletCounter++;
                int currentBullet = listOfBullets.Peek();
                int currentLock = listOfLocks.Peek();           

                if (currentLock >= currentBullet)
                {
                    listOfLocks.Dequeue();
                    listOfBullets.Pop();
                    Console.WriteLine("Bang!");
                    counter++;
                }
                else
                {
                    listOfBullets.Pop();
                    Console.WriteLine("Ping!");
                    counter++;
                }

                if (counter == sizeOfGunBarrel && listOfBullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }

            if (listOfLocks.Count == 0)
            {
                Console.WriteLine($"{listOfBullets.Count} bullets left. Earned ${value - (bulletCounter * bulletPrice)}");
            }
            else if (listOfBullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {listOfLocks.Count}");
            }
        }
    }
}
