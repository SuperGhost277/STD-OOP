using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Pokemon : Hero
    {
        private const int Evolve = 3;

        public Pokemon(string name, string weapon) : base(name,weapon)
        {
        }
        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(25))
            {
                incomingDamage = 0;
                Heal(Health * 10 / 100);
            }
            base.TakeDamage(incomingDamage);

        }
        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(Evolve)) attack = attack * 250 / 100;
            return attack;
        }
    }
}
