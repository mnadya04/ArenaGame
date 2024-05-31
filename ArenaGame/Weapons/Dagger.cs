using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        private Hero _hero;

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }

        public void SetHero(Hero hero)
        {
            _hero = hero;
        }

        public void SpecialBoost()
        {
            double strenght = _hero.Strenght;
            AttackDamage+=strenght*0.1;
            _hero.IncreaseHealth(15);
        }
    }
}
