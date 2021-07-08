using System;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> list = new Box<double>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double current = double.Parse(Console.ReadLine());
                list.Add(current);
            }

            double elementToCompare = double.Parse(Console.ReadLine());
            list.Compare(elementToCompare);

            Console.WriteLine(list.CountGreater);
        }
    }
}
