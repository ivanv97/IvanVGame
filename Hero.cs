using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanVGame
{
    abstract class Hero
    {
        public decimal HealthPoints { get; set; } = 1000.0m;
        public abstract decimal AttackPoints { get; } 
        public abstract decimal ArmorPoints { get; }

        public Random rand = new Random();
        
        /*Attacks with 80 - 120% of its attack points*/
        public virtual void Attack(Hero anotherHero)
        {
            anotherHero.ReceiveDamage(rand.Next(80, 120) * AttackPoints/100);
        }

        /*Decreases raw damage with 80 - 120% of its armor points*/
        public virtual void ReceiveDamage(decimal rawDamage)
        {
            decimal finalDamage = rawDamage - rand.Next(80, 120) * ArmorPoints / 100;
            if (finalDamage<0)
            {
                return;
            }
            HealthPoints -= finalDamage;
        }

        /* Checks if a hero is still alive,
         * else returns false and asigns 0 to health points*/
        public bool StillAlive()
        {
            if (HealthPoints <= .0m)
            {
                HealthPoints = .0m;
                return false;
            }
            return true;
        }
    }
}
