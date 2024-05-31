using System;
using ArenaGame.Weapons;

namespace ArenaGame.Heroes
{
    // it is Winx related again :>
    public class Specialist : Hero
    {
        private bool _isSmart;
        private int _hitCount;

        public Specialist(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            if (weapon is Dagger dagger)
            {
                dagger.SetHero(this);
            }
            _isSmart = GetRandomBool();
            _hitCount = 0;
        }

        public override double Attack()
        {
            _hitCount++;
            double damage = base.Attack();
            if (_isSmart==true)
            {
                IncreaseStrenghtByMultiplying(2);
                if (_hitCount==4)
                {
                    damage += 10;
                }
            }
            return damage;
        }

        // gets a random bool to define whether the specialist is smart
        private bool GetRandomBool()
        {
            return random.Next(2) == 1;
        }
    }
}

