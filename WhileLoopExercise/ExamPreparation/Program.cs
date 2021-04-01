using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string taskName = "";
            int currentGrade = 0;
            double averageGrade = 0;
            int badGrade = 0;
            int countTasks = 0;
            string lastTask = "";

            while (taskName != "Enough")
            {
                lastTask = taskName;
                taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    break;
                }
                currentGrade = int.Parse(Console.ReadLine());
                averageGrade += currentGrade;
                countTasks++;
                if (currentGrade <= 4)
                {
                    badGrade++;
                    if (badGrade == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrade} poor grades.");
                        break;
                    }
                }
            }

            if (taskName == "Enough")
            {
                Console.WriteLine($"Average score: {1.0 * averageGrade / countTasks:f2}");
                Console.WriteLine($"Number of problems: {countTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
