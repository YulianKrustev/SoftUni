namespace DefiningClasses
{
    public class cargo
    {
        private string type;
        private int weight;

        public cargo(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
