using System;
using System.Text;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                int nameStart = input.IndexOf('@') + 1;
                int nameEnd = input.IndexOf('|');
                string name = input.Substring(nameStart, nameEnd - nameStart);

                int ageStart = input.IndexOf('#') + 1;
                int ageEnd = input.IndexOf('*');
                int age = int.Parse(input.Substring(ageStart, ageEnd - ageStart));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
