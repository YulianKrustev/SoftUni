using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingPrice = int.Parse(Console.ReadLine());

            double sneakers = trainingPrice * 0.6;
            double equipment = sneakers * 0.8;
            double ball = equipment * 0.25;
            double acc = ball * 0.2;

            Console.WriteLine($"{trainingPrice + sneakers + equipment + ball + acc:f2}");

        }
    }
}
