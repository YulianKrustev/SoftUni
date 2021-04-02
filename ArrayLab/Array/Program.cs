using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            if (day > 0 && day <= dayOfWeek.Length)
            {
                Console.WriteLine(dayOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
