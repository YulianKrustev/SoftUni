using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Print(grade);
        }

        private static void Print(double grade)
        {
            string gradeWithWords = string.Empty;

            if (grade >= 2.00 && grade < 3.00)
            {
                gradeWithWords = "Fail";
            }
            else if (grade >= 3.00 && grade < 3.50)
            {
                gradeWithWords = "Poor";
            }
            else if (grade > 3.49 && grade < 4.50)
            {
                gradeWithWords = "Good";
            }
            else if (grade > 4.49 && grade < 5.50)
            {
                gradeWithWords = "Very good";
            }
            else if (grade > 4.49 && grade <= 6.00)
            {
                gradeWithWords = "Excellent";
            }
            Console.WriteLine(gradeWithWords);
        }
    }
}
