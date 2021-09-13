namespace BorderControl
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, string age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; }
        public string Age { get; }

        public string Id { get; }
    }
}
