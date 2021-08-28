using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] dough = Console.ReadLine().Split();
            string[] topping = Console.ReadLine().Split();

            Console.ReadLine();

            string doughType = dough[1].ToLower();
            string bakingType = dough[2].ToLower();
            double doughWeight = double.Parse(dough[3]);

            string toppingType = topping[1].ToLower();
            double toppingWeight = double.Parse(topping[2]);
            Dough createDough = null;
            Topping createTopping = null;

            try
            {
                createDough = new Dough(doughType, bakingType, doughWeight);
                Console.WriteLine($"{createDough.Calories:f2}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }

            try
            {
                createTopping = new Topping(toppingType, toppingWeight);
                Console.WriteLine($"{createTopping.ToppingCalories:f2}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}