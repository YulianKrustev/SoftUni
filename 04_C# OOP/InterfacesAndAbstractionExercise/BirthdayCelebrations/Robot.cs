namespace BirthdayCelebrations
{
    public class Robot : IIdentifiable, IBirthdateable
    {
        public Robot(string model, string id, string birthDate)
        {
            Model = model;
            Id = id;
            BirthDate = birthDate;
        }

        public string Model { get; }

        public string Id { get; }

        public string BirthDate { get; }
    }
}
