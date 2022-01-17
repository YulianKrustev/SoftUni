namespace KingGambit.Models
{
    using System;
    public class RoyalGuard : Person
    {
        public RoyalGuard(string name) 
            : base(name)
        {
        }

        public override void KingIsUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}