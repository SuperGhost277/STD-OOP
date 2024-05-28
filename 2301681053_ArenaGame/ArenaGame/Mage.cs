using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int HealEachNthRound = 5;
        private int attackCount;

        public Mage(string name, string weapon) : base(name, weapon)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            attackCount = attackCount + 1;
            if (attackCount % HealEachNthRound == 0 && ThrowDice(35))
            {
                Heal(StartingHealth * 60 / 100);
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(20)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
