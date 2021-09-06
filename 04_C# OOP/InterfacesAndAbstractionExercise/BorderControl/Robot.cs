namespace BorderControl
{
    public class Robot : IId
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; }

        public string Id { get; }
    }
}
