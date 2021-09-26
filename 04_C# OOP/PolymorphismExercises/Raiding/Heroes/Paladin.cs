namespace Raiding.Heroes
{
    public class Paladin : BaseHero, Global.GlobalConst
    {
        public Paladin(string name) 
            : base(name)
        {
            Power = Global.GlobalConst.paladinPower;
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}