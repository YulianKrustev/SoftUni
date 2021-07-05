using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var equal = new EqualityScale<int>(4, 2);
            Console.WriteLine(equal.AreEqual());
        }
    }
}
