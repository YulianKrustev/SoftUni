using System;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double averageEvaluation = 0;
            double currnetEvaluation = 0;
            double grade = 1;

            while (grade < 13)
            {
                currnetEvaluation = double.Parse(Console.ReadLine());
                if (currnetEvaluation >=4)
                {
                    averageEvaluation += currnetEvaluation;
                    grade++;
                }
                else
                {
                    currnetEvaluation = int.Parse(Console.ReadLine());
                    if (currnetEvaluation < 4)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    } 
                    else
                    {
                        averageEvaluation += currnetEvaluation;
                        grade++;
                    }
                }
            }
            if (grade == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(averageEvaluation / 12):f2}");
            }
            


        }
    }
}
