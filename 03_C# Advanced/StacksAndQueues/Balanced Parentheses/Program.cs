using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> bank = new Stack<char>();

            foreach (var symbol in input)
            {
                if (symbol == '(' || symbol == '[' || symbol == '{')
                {
                    bank.Push(symbol);
                }
                else if (symbol == ')' && bank.Any() && bank.Peek() == '(')
                {
                    bank.Pop();
                }
                else if (symbol == ']' && bank.Any() && bank.Peek() == '[')
                {
                    bank.Pop();
                }
                else if (symbol == '}' && bank.Any() && bank.Peek() == '{')
                {
                    bank.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine(bank.Any() ? "NO" : "YES");
            
        }
    }
}
