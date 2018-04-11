using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanVGame
{
    class Monk:Hero
    {
        public override decimal AttackPoints { get { return 120.0m; } }
        public override decimal ArmorPoints { get { return 70.0m; } }

        /* 30% chance to receive NO damage */
        public override void ReceiveDamage(decimal rawDamage)
        {            
            if (rand.Next(1, 10) <= 3)
            {
                return;
            }
            else
            {
                base.ReceiveDamage(rawDamage);
            }
        }
    }
}
