using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int bonusPoints = int.Parse(Console.ReadLine());
            int studentsPoints = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int currentPoints = int.Parse(Console.ReadLine());
                if (currentPoints > studentsPoints)
                {
                    studentsPoints = currentPoints;
                }
            }

            if (countOfStudents == 0 || countOfLectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            double totalBonus = Math.Ceiling(1.0 * studentsPoints / countOfLectures * (5 + bonusPoints));

            Console.WriteLine($"Max Bonus: {totalBonus}.");
            Console.WriteLine($"The student has attended {studentsPoints} lectures.");
        }
    }
}
