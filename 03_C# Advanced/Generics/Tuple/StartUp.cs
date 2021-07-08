using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] personBeerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string personName = personInfo[0] + " " + personInfo[1];
            string personCity = personInfo[2];

            Tuple<string, string> personTuple = new Tuple<string, string>(personName, personCity);

            string name = personBeerInfo[0];
            int amountBeer = int.Parse(personBeerInfo[1]);

            Tuple<string, int> personBeer = new Tuple<string, int>(name, amountBeer);

            int myInt = int.Parse(numbers[0]);
            double myDouble = double.Parse(numbers[1]);

            Tuple<int, double> numbersInfo = new Tuple<int, double>(myInt, myDouble);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeer.GetInfo());
            Console.WriteLine(numbersInfo.GetInfo());
        }
    }
}
