using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonCounter = 0;
            string command = Console.ReadLine();

            while (command?.ToLower() != "end of battle")
            {
                int destination = int.Parse(command);
              
                if (energy >= destination)
                {
                    energy -= destination;
                    wonCounter++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonCounter} won battles and {energy} energy");
                    return;
                }

                if (wonCounter % 3 == 0)
                {
                    energy += wonCounter;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonCounter}. Energy left: {energy}");
        }
    }
}
