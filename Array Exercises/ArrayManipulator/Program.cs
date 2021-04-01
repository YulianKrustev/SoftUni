using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                if (command.Contains("exchange"))
                {
                    numbers = Exchange(numbers, command);
                    command = Console.ReadLine();
                }
                else if (command.Contains("max"))
                {
                    Console.WriteLine(MaxEvenOrOdd(numbers, command));
                    command = Console.ReadLine();
                }
                else if (command.Contains("min"))
                {
                    Console.WriteLine(MinEvenOrOdd(numbers, command));
                    command = Console.ReadLine();
                }
                else if (command.Contains("first"))
                {
                    FirstCount(numbers, command);
                    command = Console.ReadLine();
                }
                else if (command.Contains("last"))
                {
                    LastCount(numbers, command);
                    command = Console.ReadLine();
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void LastCount(int[] numbers, string command)
        {
            bool isEven = command.Contains("even");
            bool isOdd = command.Contains("odd");
            string countAsNumber = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
                if (Char.IsDigit(command[i]))
                {
                    countAsNumber += command[i];
                }
            }

            int count = int.Parse(countAsNumber);

            if (command[6] == '-')
            {
                count *= -1;
            }

            if (count > 0 && count <= numbers.Length)
            {
                int[] digits = new int[count];


                if (isEven)
                {
                    int extractDigits = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (extractDigits == count)
                        {
                            break;
                        }

                        if (numbers[i] % 2 == 0)
                        {
                            digits[extractDigits] = numbers[i];
                            extractDigits++;
                        }
                    }

                    digits = RemoveZeros(digits);
                    digits.Reverse();
                    Console.WriteLine($"[{string.Join(", ", digits)}]");
                }
                else if (isOdd)
                {
                    int extractDigits = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (extractDigits == count)
                        {
                            break;
                        }

                        if (numbers[i] % 2 != 0)
                        {
                            digits[extractDigits] = numbers[i];
                            extractDigits++;
                        }
                    }
                    digits = RemoveZeros(digits);
                    digits.Reverse();
                    Console.WriteLine($"[{string.Join(", ", digits)}]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        private static int[] RemoveZeros(int[] digits)
        {
            int zeroCounter = 0;
            foreach (var current in digits)
            {
                if (current == 0)
                {
                    zeroCounter++;
                }
            }

            int[] digitsWithRemoveZeros = new int[digits.Length - zeroCounter];

            for (int i = 0, j = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                {
                    digitsWithRemoveZeros[j] = digits[i];
                    j++;
                }
            }

            return digitsWithRemoveZeros;
        }

        private static void FirstCount(int[] numbers, string command)
        {
            bool isEven = command.Contains("even");
            bool isOdd = command.Contains("odd");
            string countAsNumber = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
                if (Char.IsDigit(command[i]))
                {
                    countAsNumber += command[i];
                }
            }

            int count = int.Parse(countAsNumber);

            if (command[6] == '-')
            {
                count *= -1;
            }

            if (count > 0 && count <= numbers.Length)
            {
                int[] digits = new int[count];


                if (isEven)
                {
                    int extractDigits = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (extractDigits == count)
                        {
                            break;
                        }

                        if (numbers[i] % 2 == 0)
                        {
                            digits[extractDigits] = numbers[i];
                            extractDigits++;
                        } 
                    }

                    digits = RemoveZeros(digits);
                    Console.WriteLine($"[{string.Join(", ", digits)}]");
                }
                else if (isOdd)
                {
                    int extractDigits = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (extractDigits == count)
                        {
                            break;
                        }

                        if (numbers[i] % 2 != 0)
                        {
                            digits[extractDigits] = numbers[i];
                            extractDigits++;
                        }
                    }
                    digits = RemoveZeros(digits);
                    Console.WriteLine($"[{string.Join(", ", digits)}]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }


        }

        private static string MinEvenOrOdd(int[] numbers, string command)
        {
            bool isEven = command.Contains("even");
            bool isOdd = command.Contains("odd");
            int index = -1;

            if (isEven)
            {
                int currentDigit = 10;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] <= currentDigit && numbers[i] % 2 == 0)
                    {
                        currentDigit = numbers[i];
                        index = i;
                    }
                }
            }
            else if (isOdd)
            {
                int currentDigit = 10;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] <= currentDigit && numbers[i] % 2 != 0)
                    {
                        currentDigit = numbers[i];
                        index = i;
                    }
                }
            }

            if (index == -1)
            {
                return "No matches";
            }
            else
            {
                return index.ToString();
            }
        }

        private static string MaxEvenOrOdd(int[] numbers, string command)
        {
            bool isEven = command.Contains("even");
            bool isOdd = command.Contains("odd");
            int index = -1;

            if (isEven)
            {
                int currentDigit = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] >= currentDigit && numbers[i] % 2 == 0)
                    {
                        currentDigit = numbers[i];
                        index = i;
                    }
                }
            }
            else if (isOdd)
            {
                int currentDigit = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] >= currentDigit && numbers[i] % 2 != 0)
                    {
                        currentDigit = numbers[i];
                        index = i;
                    }
                }
            }

            if (index == -1)
            {
                return "No matches";
            }
            else
            {
                return index.ToString();
            }
        }

        private static int[] Exchange(int[] numbers, string command)
        {
            string indexAsNumber = string.Empty;

            for (int i = 0; i < command.Length; i++)
            {
                if (Char.IsDigit(command[i]))
                {
                    indexAsNumber += command[i];
                }
            }

            int index = int.Parse(indexAsNumber);

            if (command[9] == '-')
            {
                index *= -1;
            }

            if (index >= 0 && index < numbers.Length)
            {
                int[] newNumsOne = numbers.Skip(index + 1).Take((numbers.Length) - index).ToArray();
                int[] newNumsTwo = numbers.Skip(0).Take(index + 1).ToArray();
                numbers = new int[newNumsOne.Length + newNumsTwo.Length];
                newNumsOne.CopyTo(numbers, 0);
                newNumsTwo.CopyTo(numbers, newNumsOne.Length);
                return numbers;
            }
            else
            {
                Console.WriteLine("Invalid index");
                return numbers;
            }
        }
    }
}
