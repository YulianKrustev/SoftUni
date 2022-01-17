namespace KingGambit.Models
{
    using System;
    public class King : Person
    {
        public event EventHandler KingUnderAttack;
        public King(string name) 
            : base(name)
        {
        }

        public override void KingIsUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            KingUnderAttack?.Invoke(this, EventArgs.Empty);           
        }
    }
}