using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capcity = int.Parse(Console.ReadLine());

            double courses = (int)Math.Ceiling(1.0 * numberOfPeople / capcity);

            Console.WriteLine(courses);
        }
    }
}
