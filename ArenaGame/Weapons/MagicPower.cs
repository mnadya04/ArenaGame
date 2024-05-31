using System;
namespace ArenaGame.Weapons
{
	public class MagicPower : IWeapon
    {
        public MagicPower(string name)
        {
            Name = name;
            AttackDamage = 16;
            BlockingPower = 14;
        }

        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public void SpecialBoost()
        {
            Transformation transformation = GetRandomTransformation();
            // each transformation has different special boosts
            if (transformation==Transformation.Enchantix)
            {
                AttackDamage += 10;
            }
            if (transformation==Transformation.Believix)
            {
                BlockingPower += 10;
            }
            if (transformation==Transformation.Sirenix)
            {
                AttackDamage += 7;
                BlockingPower += 6;
            }
        }

        // gets a random transformation
        private static Transformation GetRandomTransformation()
        {
            // credit for logic how to get random enum value: https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration
            Array values = Enum.GetValues(typeof(Transformation));
            Random random = new Random();
            int index = random.Next(values.Length);
            return (Transformation)values.GetValue(index);
        }
    }
}

public enum Transformation
{
    Enchantix,
    Believix,
    Sirenix
}

