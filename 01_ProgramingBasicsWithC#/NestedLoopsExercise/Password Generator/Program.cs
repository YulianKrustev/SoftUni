using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int solution = 0;


            for (int index1 = 1; index1 <= n; index1++)
            {           
                for (int index2 = 1; index2 <= n; index2++)
                {
                    for (char index3 = 'a'; index3 < 97 + l; index3++)
                    {
                        for (char index4 = 'a'; index4 < 97 + l; index4++)
                        {
                            if (index1 > index2)
                            {
                                solution = index1 + 1;

                            }
                            else
                            {
                                solution = index2 + 1;
                            }
                            for (int index5 = solution; index5 <= n; index5++)
                            {
                                Console.Write($"{index1}{index2}{index3}{index4}{index5} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
