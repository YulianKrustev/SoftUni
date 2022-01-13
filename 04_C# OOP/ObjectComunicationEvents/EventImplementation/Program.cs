using System;

namespace EventImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            dispatcher.nameChange += handler.OnDispacherNameChange;

            string name = Console.ReadLine();

            while (name != "End")
            {
                dispatcher.Name = name;
                name = Console.ReadLine();
            }
        }
    }
}
