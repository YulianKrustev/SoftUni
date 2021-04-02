using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool correctLength = IsIsCorrectLength(password);
            bool cosnistLetterNum = IsConistLetterAndNum(password);
            bool atLeast2Digits = IsConsistTwoDigit(password);

            if (correctLength && cosnistLetterNum && atLeast2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool IsConsistTwoDigit(string password)
        {
            int digitsCounter = 0;

            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    digitsCounter++;
                }   
            }
            if (digitsCounter >= 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
        }

        private static bool IsConistLetterAndNum(string password)
        {
            bool result = password.All(Char.IsLetterOrDigit);
            if (!result)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            return result;
        }

        private static bool IsIsCorrectLength(string password)
        {
            if (password.Length > 5 && password.Length < 11)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }
    }
}
