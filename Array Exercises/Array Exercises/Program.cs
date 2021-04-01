using System;
using System.Linq;

namespace Array_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int countVagons = int.Parse(Console.ReadLine());

            int[] peopleInTrain = new int[countVagons];
            int allPeople = 0;

            for (int i = 0; i < countVagons; i++)
            {
                peopleInTrain[i] = int.Parse(Console.ReadLine());
                allPeople += peopleInTrain[i];
            }
            
            Console.WriteLine(string.Join(" ", peopleInTrain));
            Console.WriteLine(allPeople);
        }
    }
}
