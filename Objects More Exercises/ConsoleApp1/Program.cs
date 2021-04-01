using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adfa = "341235";
            string a = "341232455";

            Ako ako = new Ako(adfa, a);
            Console.WriteLine(ako);
        }
    }

    class Ako
    {
        public Ako(string mirish, string sfgg)
        {
            Mirish = mirish;
            Sfggsh = sfgg;

        }
        public string Mirish { get; set; }
        public string Sfggsh { get; set; }
    }
}
