using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int lostGamesCounter = 0;
            double rageExpeses = 0;
            int trashKeyboard = 0;

            for (int i = 0; i < lostGames; i++)
            {
                lostGamesCounter++;

                if (lostGamesCounter % 2 == 0)
                {
                    rageExpeses += headsetPrice;
                }
                if (lostGamesCounter % 3 == 0)
                {
                    rageExpeses += mousePrice;
                }
                if ((lostGamesCounter % 3 == 0) && (lostGamesCounter % 2 == 0))
                {
                    rageExpeses += keyboardPrice;
                    trashKeyboard++;
                }
                if (trashKeyboard == 2)
                {
                    rageExpeses += displayPrice;
                    trashKeyboard = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpeses:f2} lv.");
        }
    }
}
