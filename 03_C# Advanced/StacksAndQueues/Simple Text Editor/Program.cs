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
                        builder.Remove(builder.Length - int.Parse(tokens[1]), int.Parse(tokens[1]));
                        undoCommand.Push(builder.ToString());
                        break;
                    case 3:
                        Console.WriteLine(builder[int.Parse(tokens[1]) - 1]);
                        break;
                    case 4:
                        undoCommand.Pop();
                        builder = new StringBuilder();
                        builder.Append(undoCommand.Peek());
                        break;
                }
            }
        }
    }
}
