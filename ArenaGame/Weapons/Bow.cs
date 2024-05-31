using System;
namespace ArenaGame.Weapons
{
	public class Bow : IWeapon
	{
        private bool _isPoisoned;
        private double _poisonDamage;
        private int _poisonDuration;

        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 1;
            _isPoisoned = false;
            _poisonDamage = 10;
            _poisonDuration = 3;

        }

        public void SpecialBoost()
        {
            _isPoisoned = true;

            if (_isPoisoned)
            {
                // add poison damage
                AttackDamage += _poisonDamage;
                // decrease poison duration
                _poisonDuration--;

                if (_poisonDuration <= 0)
                {
                    // reset poison effect after duration ends
                    _isPoisoned = false;
                    AttackDamage = 20;
                }
            }
        }
    }
}

