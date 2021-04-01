using System;

namespace WhileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string currentBook = "";
            int checkedBook = 0;

            while (bookName != currentBook)
            {
                currentBook = Console.ReadLine();
                checkedBook++;

                if (currentBook == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!\nYou checked {checkedBook - 1} books.");
                    break;
                }
            }

            if (bookName == currentBook)
            {
                Console.WriteLine($"You checked {checkedBook - 1} books and found it.");
            }
        }
    }
}
