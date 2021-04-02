using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double countStudents = double.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());
            double sabesPrice = Math.Ceiling(countStudents * 1.1) * lightsabers;
            double robesPrice = countStudents * robe;
            double beltsPrice = (countStudents - Math.Floor(countStudents / 6)) * belt;
            double neededBudget = beltsPrice + sabesPrice + robesPrice;
            

            if (budget >= neededBudget)
            {
                Console.WriteLine($"The money is enough - it would cost {neededBudget:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededBudget - budget:f2}lv more.");
            }
        }
    }
}
