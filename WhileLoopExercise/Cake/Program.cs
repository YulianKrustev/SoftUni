using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakePieces = cakeLength * cakeWidth;
            int takePieces = 0;

            while (cakePieces >= takePieces)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    takePieces += int.Parse(input);
                }
            }
            if (takePieces > cakePieces)
            {
                Console.WriteLine($"No more cake left! You need {takePieces - cakePieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakePieces - takePieces} pieces are left.");
            }
        }
    }
}
