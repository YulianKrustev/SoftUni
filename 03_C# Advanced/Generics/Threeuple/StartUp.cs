using System;
using System.Text;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] personBeerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] accauntInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string personName = personInfo[0] + " " + personInfo[1];
            string personStreet = personInfo[2];
            StringBuilder personCity = new StringBuilder();

            for (int i = 3; i < personInfo.Length; i++)
            {
                if (i == 3)
                {
                    personCity.Append(personInfo[i]);
                }
                else
                {
                    personCity.Append($" {personInfo[i]}");
                }
            }

            Threeuple<string, string, string> personTuple = new Threeuple<string, string, string>(personName, personStreet, personCity.ToString());

            string name = personBeerInfo[0];
            int amountBeer = int.Parse(personBeerInfo[1]);
            string condition = personBeerInfo[2];

            if (condition == "drunk")
            {
                condition = "True";
            }
            else
            {
                condition = "False";
            }

            Threeuple<string, int, string> personBeer = new Threeuple<string, int, string>(name, amountBeer, condition);

            string accountName = accauntInfo[0];
            double accauntBalance = double.Parse(accauntInfo[1]);
            string bankName = accauntInfo[2];

            Threeuple<string, double, string> numbersInfo = new Threeuple<string, double, string>(accountName, accauntBalance, bankName);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeer.GetInfo());
            Console.WriteLine(numbersInfo.GetInfo());
        }
    }
}
