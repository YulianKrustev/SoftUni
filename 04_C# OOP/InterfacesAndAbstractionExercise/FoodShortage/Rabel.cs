namespace FoodShortage
{
    public class Rabel : IBuyer
    {
        public Rabel(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; }
        public string Age { get; }

        public string Group { get; }

        public int Food { get; private set; } = 0;

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
