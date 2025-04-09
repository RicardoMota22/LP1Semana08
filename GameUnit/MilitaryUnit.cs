namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        //public override int Health { get => base.Health; set => base.Health = value; }
        public override int Health { get => base.Health + XP;}
        public override float Cost { get => AttackPower + XP;}

        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack (Unit u)
        {
            XP = Health - AttackPower;
        }
    }
}
