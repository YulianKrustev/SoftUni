namespace WildFarm.Food
{
    public abstract class Foods
    {
        private int quantity;

        public Foods(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}