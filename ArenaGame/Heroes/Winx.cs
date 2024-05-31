using System;
using ArenaGame.Weapons;

namespace ArenaGame.Heroes
{
	public class Winx : Hero
	{
        public Winx(string name, double armour, double strenght, IWeapon weapon) : base(name, armour, strenght, weapon)
		{
            if (weapon is Dagger dagger)
            {
                dagger.SetHero(this);
            }
        }

        public override double Defend(double damage)
        {
            // posibility of hiding to recover
            double posibility = random.NextDouble();
            if (Health<80 && posibility<=0.3)
            {
                IncreaseHealth(20);
                return 0;
            }
            return base.Defend(damage);
        }
    }
}

