using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ");
            Dictionary<string, int> info = new Dictionary<string, int>();

            foreach (var runner in participants)
            {
                info.Add(runner, 0);
            }

            string data = Console.ReadLine();
            Regex nameRegex = new Regex(@"[\W0-9]");
            Regex numberRegex = new Regex(@"[\WA-z]");

            while (data != "end of race")
            {

                if (nameRegex.IsMatch(data))
                {
                    string name = nameRegex.Replace(data, "");

                    if (info.ContainsKey(name))
                    {
                        if (numberRegex.IsMatch(data))
                        {
                            string n = numberRegex.Replace(data, "");
                            int sum = 0;
                            foreach (var number in n)
                            {
                                sum += int.Parse(number.ToString());
                            }
                            info[name] += sum;
                        }                      
                    }
                }

                data = Console.ReadLine();
            }

            int counter = 1;

            foreach (var player in info.OrderByDescending(x => x.Value))
            {
                if (counter == 4)
                {
                    break;
                }

                string place = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
                Console.WriteLine($"{counter}{place} place: {player.Key}");
                counter++;
            }
        }
    }
}
