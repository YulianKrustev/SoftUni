using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 30 > 60)
            {
                hours += 1;
                minutes -= 30;
                if (hours > 23)
                {
                    hours = 0;
                }
            }
            else
            {
                minutes += 30;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
