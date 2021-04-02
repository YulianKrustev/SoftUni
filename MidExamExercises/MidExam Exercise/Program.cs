using System;

namespace MidExam_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            int peopelForHour = firstEmployee + secondEmployee + thirdEmployee;

            int counter = 0;
            int time = 0;

            while (people > 0)
            {
                if (counter % 4 != 0)
                {
                    counter = 0;
                    time++;
                    continue;
                }
                people -= peopelForHour;
                time++;
                counter++;
            }

            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
