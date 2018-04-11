using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanVGame
{
    class Knight : Hero
    {
        public override decimal AttackPoints { get { return 100.0m; } }
        public override decimal ArmorPoints { get { return 80.0m; } }


        /* 20% chance to receive NO damage */
        public override void ReceiveDamage(decimal rawDamage)
        {
            if (rand.Next(1, 5) == 1)
            {
                return;
            }
            else
            {
                base.ReceiveDamage(rawDamage);
            }
        }

        /* 10% chance to attack 2x harder */
        public override void Attack(Hero anotherHero)
        {
            if (rand.Next(1, 10) == 1)
            {
                anotherHero.ReceiveDamage(2 * rand.Next(80, 120) * AttackPoints/100);
            }
            else
            {
                base.Attack(anotherHero);
            }
        }


    }
}
