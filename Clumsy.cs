using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanVGame
{
    class Clumsy : Hero
    {
        public override decimal AttackPoints { get { return 100.0m; } }
        public override decimal ArmorPoints { get { return 40.0m; } }


        /* Clumsy hero who can attack himself (30%)
         * or attack 4 times stronger (30%)*/
        public override void Attack(Hero anotherHero)
        {
            int random = rand.Next(1, 10);
            if (random <= 3)
            {
                ReceiveDamage(rand.Next(80, 120) * AttackPoints / 100);
            }
            else if (random > 3 && random <= 6)
            {
                anotherHero.ReceiveDamage(4 * rand.Next(80, 120) * AttackPoints / 100);
            }
            else
            {
                base.Attack(anotherHero);
            }
        }

        
    }
}
