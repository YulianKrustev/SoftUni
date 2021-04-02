using System;

namespace Train_the_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();
            double avarageAssessment = 0;
            int numberOfTasks = 0;

            while (task != "Finish")
            {
                double assessment = 0;
                for (int i = 0; i < juryMembers; i++)
                {
                    assessment += double.Parse(Console.ReadLine());
                }
                numberOfTasks++;
                avarageAssessment += assessment / juryMembers;
                Console.WriteLine($"{task} - {assessment / juryMembers:f2}.");
                task = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {avarageAssessment / numberOfTasks:f2}.");
        }
    }
}
