using System;

namespace TypeOfDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            switch (typeOfDay)
            {
                case "Weekday":
                    if ((age >= 0) && (age < 19))
                    {
                        Console.WriteLine("12$");
                    }
                    else if ((age > 18) && (age < 65))
                    {
                        Console.WriteLine("18$");
                    }
                    else if ((age > 64) && (age < 123))
                    {
                        Console.WriteLine("12$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if ((age >= 0) && (age < 19))
                    {
                        Console.WriteLine("15$");
                    }
                    else if ((age > 18) && (age < 65))
                    {
                        Console.WriteLine("20$");
                    }
                    else if ((age > 64) && (age < 123))
                    {
                        Console.WriteLine("15$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if ((age >= 0) && (age < 19))
                    {
                        Console.WriteLine("5$");
                    }
                    else if ((age > 18) && (age < 65))
                    {
                        Console.WriteLine("12$");
                    }
                    else if ((age > 64) && (age < 123))
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
            }
        }
    }
}
