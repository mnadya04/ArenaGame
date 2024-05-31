using System;
namespace ArenaGame.Weapons
{
	public class Dragon : IWeapon
	{
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Dragon(string name)
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 10;
        }

        public void SpecialBoost()
        { 
            double speed = AttackDamage/100;
            BlockingPower *= speed;
        }
    }
}

