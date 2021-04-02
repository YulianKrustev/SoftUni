using System;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Regex jackpot = new Regex(@"([$]{20})|([@]{20})|([#]{20})|([\^]{20})");
            Regex winTicket = new Regex(@"([@]{6,10})|([#]{6,10})|([$]{6,10})|([\^]{6,10})");
            string result = string.Empty;

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string leftSide = ticket.Substring(0, 10);
                    string rightSide = ticket.Substring(10, 10);
                    Match left = winTicket.Match(leftSide);
                    Match right = winTicket.Match(rightSide);

                    if (jackpot.IsMatch(ticket))
                    {
                        result = ($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                    }
                    else if (left.Success && right.Success)
                    {
                        if (leftSide.Length <= rightSide.Length)
                        {
                            result = ($"ticket \"{ticket}\" - {left.Length}{left.Value[0]}");
                        }
                        else
                        {
                            result = ($"ticket \"{ticket}\" - {right.Length}{right.Value[0]}");
                        }
                    }
                    else
                    {
                        result = ($"ticket \"{ ticket}\" - no match");
                    }
                }
                else
                {
                    result = ("invalid ticket");
                }

                Console.WriteLine(result);
            }
        }
    }
}
