namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }

        public Hero(string name, string weapon)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            if (weapon=="Sword")
            {
                Strength = 150;
            }
            else if (weapon=="Bazooka")
            {
                Strength = 220;
            }
            else if (weapon=="MagicWand")
            {
                Strength = 130;
            }
            else if (weapon =="Rock")
            {
                Strength = 110;
            }
            else
            {
                Strength = 100;
            }
        }

        public virtual int Attack()
        {
            return (Strength * Random.Shared.Next(80, 121)) / 100;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
