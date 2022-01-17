namespace KingGambit.Models
{
    using System;
    public interface IPerson
    {
        string Name { get; }

        void KingIsUnderAttack(object sender, EventArgs args);
    }
}
