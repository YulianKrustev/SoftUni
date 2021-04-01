using System;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < usernames.Length; j++)
            {
                string current = usernames[j];
                string valid = string.Empty;
                bool isValid = false;

                if (current.Length >= 3 && current.Length <= 16)
                {
                    for (int i = 0; i < current.Length; i++)
                    {
                        if (char.IsLetterOrDigit(current[i]) || current[i] == '-' || current[i] == '_')
                        {
                            valid += current[i];
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(valid);
                }
            }
        }
    }
}
