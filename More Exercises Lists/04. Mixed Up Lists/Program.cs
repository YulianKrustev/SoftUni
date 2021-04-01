using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_Up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            List<int> listTwo = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            int indexOne = 0;
            int indexTwo = 0;

            if (listOne.Count > listTwo.Count)
            {
                indexOne = Math.Min(listOne[listOne.Count - 1], listOne[listOne.Count - 2]);
                indexTwo = Math.Max(listOne[listOne.Count - 1], listOne[listOne.Count - 2]);
            }
            else
            {
                listTwo.Reverse();
                indexOne = Math.Min(listTwo[listTwo.Count - 1], listTwo[listTwo.Count - 2]);
                indexTwo = Math.Max(listTwo[listTwo.Count - 1], listTwo[listTwo.Count - 2]);
            }


            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(listOne.Count, listTwo.Count); i++)
            {
                if (listOne[i] > indexOne && listOne[i] < indexTwo)
                {
                    result.Add(listOne[i]);
                }

                if (listTwo[i] > indexOne && listTwo[i] < indexTwo)
                {
                    result.Add(listTwo[i]);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
