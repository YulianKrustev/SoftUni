namespace BirthdayCelebrations
{
    public class Pet : IBirthdateable
    {
        public Pet(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; }
        public string BirthDate { get; }
    }
}
