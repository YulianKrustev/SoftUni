using System;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal km = 1.0M * meters / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
