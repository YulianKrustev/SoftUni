namespace Raiding.Heroes
{
    public class Druid : BaseHero, Global.GlobalConst
    {
        public Druid(string name)
            : base(name)
        {
            Power = Global.GlobalConst.druidPower;
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}