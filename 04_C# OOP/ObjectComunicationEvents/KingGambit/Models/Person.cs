using System;

namespace KingGambit.Models
{
    public abstract class Person : IPerson
    {

        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public abstract void KingIsUnderAttack(object sender, EventArgs args);
    }
}