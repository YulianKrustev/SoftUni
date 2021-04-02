using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var inputOne = Console.ReadLine();
            var inputTwo = Console.ReadLine();

            string getMax = GetMax(type, inputOne, inputTwo);

            Console.WriteLine(getMax);
        }

        private static string GetMax(string type, string inputOne, string inputTwo)
        {
            string getMax = string.Empty;

            switch (type)
            {
                case "int":
                    if (int.Parse(inputOne) >= int.Parse(inputTwo))
                    {
                        getMax = inputOne;
                    }
                    else
                    {
                        getMax = inputTwo; 
                    }
                    break;
                case "char":
                    if (char.Parse(inputOne) >= char.Parse(inputTwo))
                    {
                        getMax = inputOne;
                    }
                    else
                    {
                        getMax = inputTwo;
                    }
                    break;
                case "string":

                    if (inputOne.CompareTo(inputTwo) >= 0)
                    {
                        getMax = inputOne;
                    }
                    else
                    {
                        getMax = inputTwo;
                    }
                    break;
            }
            return getMax;
        }
    }
}
