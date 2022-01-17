namespace KingGambit.Models
{
    using System;
    public class Footman : Person
    {
        public Footman(string name) 
            : base(name)
        {
        }

        public override void KingIsUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}