using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            double needSum = 0;
            double saveSum = 0;

            while (destination != "End")
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                needSum = double.Parse(Console.ReadLine());

                while (saveSum < needSum)
                {
                    saveSum += double.Parse(Console.ReadLine());

                }
               
                Console.WriteLine($"Going to {destination}!");
                saveSum = 0;
            }
        }
    }
}
