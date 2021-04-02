using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"([A-Za-z0-9]+[-_.]?[A-Za-z0-9]+)@{1}([A-za-z][A-za-z0-9][-._]?[A-Za-z0-9]+\.[A-Za-z]+)+");


            Console.WriteLine(string.Join(Environment.NewLine, pattern.Matches(input)));
        }
    }
}
