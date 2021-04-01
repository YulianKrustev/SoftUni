using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterSequence = Console.ReadLine();

            for (int i = 0; i < characterSequence.Length; i++)
            {
                Console.WriteLine(characterSequence[i]);
            }
        }
    }
}
