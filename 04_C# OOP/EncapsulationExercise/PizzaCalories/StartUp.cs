using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split()[1];               

                string[] inputDoughInfo = Console.ReadLine().Split();
                string flourType = inputDoughInfo[1];
                string bakingType = inputDoughInfo[2];
                double doughWeight = double.Parse(inputDoughInfo[3]);

                Dough currentDough = new Dough(flourType, bakingType, doughWeight);

                Pizza currentPizza = new Pizza(pizzaName, currentDough);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] currentTopping = command.Split();

                    string toppingType = currentTopping[1];
                    double toppingWeight = double.Parse(currentTopping[2]);

                    Topping currenttopping = new Topping(toppingType, toppingWeight);
                    currentPizza.AddToping(currenttopping);

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{currentPizza.Name} - {currentPizza.TotalCalories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}