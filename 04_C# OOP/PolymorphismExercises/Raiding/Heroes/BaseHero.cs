

namespace Raiding.Heroes
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int Power { get; protected set; }

        public virtual string CastAbility()
        {
            return null;
        }
    }
}
