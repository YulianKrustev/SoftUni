using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            Stack<string> undoCommand = new Stack<string>();
            int count = int.Parse(Console.ReadLine());
            undoCommand.Push(builder.ToString());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                int command = int.Parse(tokens[0]);

                switch (command)
                {
                    case 1:
                        builder.Append(tokens[1]);
                        undoCommand.Push(builder.ToString());
                        break;
                    case 2:
                        int countToRemove = int.Parse(tokens[1]);
                        builder.Remove(builder.Length - countToRemove, countToRemove);
                        undoCommand.Push(builder.ToString());
                        break;
                    case 3:
                        int indexToPrint = int.Parse(tokens[1]);
                        Console.WriteLine(builder[indexToPrint - 1]);
                        break;
                    case 4:
                        undoCommand.Pop();
                        builder.Clear();
                        builder.Append(undoCommand.Peek());
                        break;
                }
            }
        }
    }
}
