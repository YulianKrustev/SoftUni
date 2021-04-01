using System;
using System.Linq;
using System.Text;

namespace Strings_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reverse = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input[i];
                }
                StringBuilder rs = new StringBuilder();
                rs.Append(input);
                rs.Append(" = ");
                rs.Append(reverse);
                Console.WriteLine(rs);
                input = Console.ReadLine();
            }
        }
    }
}
