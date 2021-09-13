namespace FoodShortage
{
    public class Citizen : IIdentifiable, IBirthdateable, IBuyer
    {
        public Citizen(string name, string age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }

        public string Name { get; }
        public string Age { get; }

        public string Id { get; }

        public string BirthDate { get; }

        public int Food { get; private set; } = 0;

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
