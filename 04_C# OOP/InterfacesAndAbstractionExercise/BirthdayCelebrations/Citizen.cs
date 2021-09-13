namespace BirthdayCelebrations
{
    public class Citizen : IIdentifiable, IBirthdateable
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
    }
}
