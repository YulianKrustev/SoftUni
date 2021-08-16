namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Coffee coffee = new Coffee("2", 2.3m, 30);
            System.Console.WriteLine(coffee.Milliliters);

            Fish fish = new Fish("asf", 2);

            Cake des = new Cake("sad");

            System.Console.WriteLine(fish.Grams);

            System.Console.WriteLine($"{des.Price} {des.Calories}");
        }
    }
}