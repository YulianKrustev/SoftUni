using System;
using System.Linq;

namespace Shot_For_The_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            string command = Console.ReadLine();
            int shotTargets = 0;

            while (command.ToUpper() != "END")
            {
                int targetIndex = int.Parse(command);

                if (targetIndex >= 0 && targetIndex < targets.Length)
                {
                    int target = targets[targetIndex];
                    targets[targetIndex] = -1;
                    shotTargets++;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > -1 && targets[i] > target)
                        {
                            targets[i] -= target;
                        }
                        else if (targets[i] > -1 && targets[i] <= target)
                        {
                            targets[i] += target;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
        }
    }
}
