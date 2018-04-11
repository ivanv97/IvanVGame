using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanVGame
{
    class Assassin:Hero
    {
        public override decimal AttackPoints { get { return 110.0m; } }
        public override decimal ArmorPoints { get { return 50.0m; } }


        /* 30% chance to attack 3x harder */
        public override void Attack(Hero anotherHero)
        {
            if (rand.Next(1, 10) <= 3)
            {
                anotherHero.ReceiveDamage(3 * rand.Next(80, 120) * AttackPoints/100);
            }
            else
            {
                base.Attack(anotherHero);
            }
        }


    }
}
