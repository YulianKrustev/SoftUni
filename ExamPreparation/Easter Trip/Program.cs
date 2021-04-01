using System;

namespace Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationDestination = Console.ReadLine();
            string vacationDate = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());

            switch (vacationDestination)
            {
                case "Germany":
                    if (vacationDate == "21-23")
                    {
                        Console.WriteLine($"Easter trip to Germany : {duration * 32:f2} leva.");
                    }
                    else if (vacationDate == "24-27")
                    {
                        Console.WriteLine($"Easter trip to Germany : {duration * 37:f2} leva.");
                    }
                    else if (vacationDate == "28-31")
                    {
                        Console.WriteLine($"Easter trip to Germany : {duration * 43:f2} leva.");
                    }
                    break;
                case "Italy":
                    if (vacationDate == "21-23")
                    {
                        Console.WriteLine($"Easter trip to Italy : {duration * 28:f2} leva.");
                    }
                    else if (vacationDate == "24-27")
                    {
                        Console.WriteLine($"Easter trip to Italy : {duration * 32:f2} leva.");
                    }
                    else if (vacationDate == "28-31")
                    {
                        Console.WriteLine($"Easter trip to Italy : {duration * 39:f2} leva.");
                    }
                    break;
                case "France":
                    if (vacationDate == "21-23")
                    {
                        Console.WriteLine($"Easter trip to France : {duration * 30:f2} leva.");
                    }
                    else if (vacationDate == "24-27")
                    {
                        Console.WriteLine($"Easter trip to France : {duration * 35:f2} leva.");
                    }
                    else if (vacationDate == "28-31")
                    {
                        Console.WriteLine($"Easter trip to France : {duration * 40:f2} leva.");
                    }
                    break;
            }
        }
    }
}
