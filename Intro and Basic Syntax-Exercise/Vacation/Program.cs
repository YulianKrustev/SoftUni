using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeopele = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            switch (day)
            {
                case "Friday":
                    if ((typePeople == "Students") && (countPeopele >= 30))
                    {
                        totalPrice = (countPeopele * 8.45) * 0.85;
                    }
                    else if ((typePeople == "Students") && (countPeopele < 30))
                    {
                        totalPrice = countPeopele * 8.45;
                    }
                    else if ((typePeople == "Business") && (countPeopele >= 100))
                    {
                        totalPrice = (countPeopele - 10) * 10.90;
                    }
                    else if ((typePeople == "Business") && (countPeopele < 100))
                    {
                        totalPrice = countPeopele * 10.90;
                    }
                    else if ((typePeople == "Regular") && (countPeopele >= 10) && (countPeopele <= 20))
                    {
                        totalPrice = (countPeopele * 15.00) * 0.95;
                    }
                    else if (typePeople == "Regular")
                    {
                        totalPrice = countPeopele * 15.00;
                    }
                    break;
                case "Saturday":
                    if ((typePeople == "Students") && (countPeopele >= 30))
                    {
                        totalPrice = (countPeopele * 9.80) * 0.85;
                    }
                    else if ((typePeople == "Students") && (countPeopele < 30))
                    {
                        totalPrice = countPeopele * 9.80;
                    }
                    else if ((typePeople == "Business") && (countPeopele >= 100))
                    {
                        totalPrice = (countPeopele - 10) * 15.60;
                    }
                    else if ((typePeople == "Business") && (countPeopele < 100))
                    {
                        totalPrice = countPeopele * 15.60;
                    }
                    else if ((typePeople == "Regular") && (countPeopele >= 10) && (countPeopele <= 20))
                    {
                        totalPrice = (countPeopele * 20.00) * 0.95;
                    }
                    else if (typePeople == "Regular")
                    {
                        totalPrice = countPeopele * 20.00;
                    }
                    break;
                case "Sunday":
                    if ((typePeople == "Students") && (countPeopele >= 30))
                    {
                        totalPrice = (countPeopele * 10.46) * 0.85;
                    }
                    else if ((typePeople == "Students") && (countPeopele < 30))
                    {
                        totalPrice = countPeopele * 10.46;
                    }
                    else if ((typePeople == "Business") && (countPeopele >= 100))
                    {
                        totalPrice = (countPeopele - 10) * 16.00;
                    }
                    else if ((typePeople == "Business") && (countPeopele < 100))
                    {
                        totalPrice = countPeopele * 16.00;
                    }
                    else if ((typePeople == "Regular") && (countPeopele >= 10) && (countPeopele <= 20))
                    {
                        totalPrice = (countPeopele * 22.50) * 0.95;
                    }
                    else if (typePeople == "Regular")
                    {
                        totalPrice = countPeopele * 22.50;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
