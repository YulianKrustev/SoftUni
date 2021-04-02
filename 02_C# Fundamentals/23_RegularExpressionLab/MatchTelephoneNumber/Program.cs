using System;
using System.Text.RegularExpressions;

namespace MatchTelephoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneString = Console.ReadLine();
            Regex validPhonesPatter = new Regex(@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");

            Console.WriteLine(string.Join(", ", validPhonesPatter.Matches(phoneString)));

        }
    }
}
