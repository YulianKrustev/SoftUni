using System;

namespace Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decrypt = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char currentSymbol = char.Parse(Console.ReadLine());
                decrypt += (char)((int)currentSymbol + key);
            }
            Console.WriteLine(decrypt);
        }
    }
}
