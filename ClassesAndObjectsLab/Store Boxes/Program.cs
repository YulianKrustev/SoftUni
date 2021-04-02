using System;
using System.Collections.Generic;
using System.Linq;


namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split();

                int serialNumber = int.Parse(data[0]);
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);
                decimal priceForBox = itemQuantity * itemPrice;

                
                Box box = new Box();
                box.Item = new Item();
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;

                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.PriceForBox = priceForBox;
                boxes.Add(box);
                input = Console.ReadLine();

            }

            foreach (Box box in boxes.OrderByDescending(x => x.PriceForBox).ToList())
            {
                Console.WriteLine($"{box.SerialNumber}" +
                    $"{Environment.NewLine}-- {box.Item.Name} - ${box.Item.Price:f2}: { box.ItemQuantity}" +
                    $"{Environment.NewLine}-- ${box.PriceForBox:f2}");
            }
            
        }
        class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        class Box
        {
            public Box()
            {
                Item item = new Item();
            }

            public int SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceForBox { get; set; }
        }
    }
}
