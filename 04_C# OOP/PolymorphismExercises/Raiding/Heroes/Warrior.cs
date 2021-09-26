namespace Raiding.Heroes
{
    public class Warrior : BaseHero, Global.GlobalConst
    {
        public Warrior(string name) 
            : base(name)
        {
            Power = Global.GlobalConst.warriorPower;
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}