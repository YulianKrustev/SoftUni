using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCharacters();
        }

        private static void PrintCharacters()
        {
            int firstCharacter = char.Parse(Console.ReadLine());
            int secondCharacter = char.Parse(Console.ReadLine());
            int smaller = Math.Min(firstCharacter, secondCharacter);
            int bigger = Math.Max(firstCharacter, secondCharacter);

            for (int i = smaller + 1; i < bigger; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
