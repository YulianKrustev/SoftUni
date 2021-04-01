using System;
using System.Linq;

namespace LadyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            long sizeOfField = long.Parse(Console.ReadLine());
            long[] locationOfLadyBugs = Console.ReadLine()
                                                .Split()
                                                .Select(long.Parse)
                                                .ToArray();
            string command = string.Empty;
            long[] bugs = new long[sizeOfField];

            for (int i = 0; i < locationOfLadyBugs.Length; i++)
            {
                bugs[locationOfLadyBugs[i]] = 1;
            }

            while ((command = Console.ReadLine()) != "end")
            {
                bool itIsLeft = false;
                bool itItRight = false;

                if (command.Contains("left"))
                {
                    command = command.Replace("left", " ");
                    itIsLeft = true;
                }
                else if (command.Contains("right"))
                {
                    command = command.Replace("right", " ");
                    itItRight = true;
                }

                long[] currentCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .Select(long.Parse)
                                               .ToArray();
                if ((currentCommand[0] >= 0) && (currentCommand[0] <= sizeOfField))
                {
                    if (bugs[currentCommand[0]] == 1)
                    {
                        bugs[currentCommand[0]] = 0;

                        if (itIsLeft)
                        {
                            long i = 0;
                            long a = currentCommand[0];
                            long b = currentCommand[1];

                            while ((a - (b + i) >= 0) && (a - (b + i) < sizeOfField))
                            {
                                if (bugs[a - (b + i)] == 0)
                                {
                                    bugs[a - (b + i)] = 1;
                                    break;
                                }
                                i++;
                            }
                        }
                        else if (itItRight)
                        {
                            long i = 0;
                            long a = currentCommand[0];
                            long b = currentCommand[1];

                            while ((a + (b + i) >= 0) && (a + (b + i) < sizeOfField))
                            {
                                if (bugs[a + (b + i)] == 0)
                                {
                                    bugs[a + (b + i)] = 1;
                                    break;
                                }
                                i++;

                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", bugs));
        }
    }
}
