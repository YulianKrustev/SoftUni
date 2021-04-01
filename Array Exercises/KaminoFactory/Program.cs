using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string inputDna = string.Empty;

            int bestSum = 0;
            int bestSequence = 1;
            int bestIndex = 0;
            int[] bestDna = new int[length];
            int counterDna = 0;
            int bestSampler = 0;

            while ((inputDna = Console.ReadLine()) != "Clone them!")
            {
                inputDna = inputDna.Replace("!", " ");
                int[] currentDna = inputDna.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();
                int sum = 0;
                int sequence = 1;
                int firstIndex = -1;
                counterDna++;

                for (int i = 0; i < currentDna.Length; i++)
                {

                    if (currentDna[i] == 1)
                    {
                        sum += 1;                       
                    }
                }
                for (int i = 0; i < currentDna.Length -1; i++)
                {
                    if (currentDna[i] + currentDna[i+1] == 2)
                    {
                        sequence++;
                        firstIndex = i;
                    }
                }

                if ((sequence > bestSequence) ||
                    (sequence == bestSequence) && (firstIndex < bestIndex) ||
                    (sequence == bestSequence) && (firstIndex == bestIndex) && (sum > bestSum))
                {
                    bestSequence = sequence;
                    bestIndex = firstIndex;
                    bestSum = sum;
                    bestDna = currentDna;
                    bestSampler = counterDna;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSampler} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
