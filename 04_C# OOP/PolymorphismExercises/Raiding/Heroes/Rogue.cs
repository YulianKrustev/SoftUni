namespace Raiding.Heroes
{
    public class Rogue : BaseHero, Global.GlobalConst
    {
        public Rogue(string name) 
            : base(name)
        {
            Power = Global.GlobalConst.roguePower;
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}