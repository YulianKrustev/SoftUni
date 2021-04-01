using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double area = Area(width, hight);
            Console.WriteLine(area);
        }

        private static double Area(double width, double hight)
        {
            return width * hight;
        }
    }
}
