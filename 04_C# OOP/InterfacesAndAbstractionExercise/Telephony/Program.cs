using System;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] telephones = Console.ReadLine()
                                            .Split();

            string[] webAddresses = Console.ReadLine()
                                           .Split();

            Smartphone smartPhone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in telephones)
            {
                bool isValid = IsValid(number);

                if (number.Length == 7 && isValid)
                {
                    stationaryPhone.Calling(number);
                }
                else if(number.Length == 10 && isValid)
                {
                    smartPhone.Calling(number);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var webAddrees in webAddresses)
            {
                if (webAddrees.Any(x => char.IsDigit(x)) || string.IsNullOrEmpty(webAddrees))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    smartPhone.Browsing(webAddrees);
                }
            }
        }

        private static bool IsValid(string number) => number.All(x => char.IsDigit(x));

    }
}
