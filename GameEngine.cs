using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanVGame
{
    class GameEngine
    {        
        public Hero HeroFirst { get; set; }
        public Hero HeroSecond { get; set; }

        private bool canAttack = true;
        Random rand = new Random();

        /* Initializes type of hero depending on character parameter and
         first or second hero depending on integer */
        public void InitializeHero(int i, char ch)
        {
            switch (ch)
            {
                case 'w':
                    if (i == 1)
                    {
                        HeroFirst = new Warrior();
                    }
                    else
                    {
                        HeroSecond = new Warrior();
                    }
                    break;
                case 'k':
                    if (i == 1)
                    {
                        HeroFirst = new Knight();
                    }
                    else
                    {
                        HeroSecond = new Knight();
                    }
                    break;
                case 'a':
                    if (i == 1)
                    {
                        HeroFirst = new Assassin();
                    }
                    else
                    {
                        HeroSecond = new Assassin();
                    }
                    break;
                case 'm':
                    if (i == 1)
                    {
                        HeroFirst = new Monk();
                    }
                    else
                    {
                        HeroSecond = new Monk();
                    }                    
                    break;
                case 'c':
                    if (i==1)
                    {
                        HeroFirst = new Clumsy();
                    }
                    else
                    {
                        HeroSecond = new Clumsy();
                    }
                    break;
            }
        }


        /* 50/50 chance for each hero to start attacking first */
        public int RandomStart()
        {
            if (rand.Next(1,10) <= 5)
            {
                return 1;
            }
            return 2;
        }

        /* Ensures both heroes types have been selected */
        public bool ReadyToStart()
        {
            if (HeroFirst != null && HeroSecond != null)
            {
                return true;
            }
            return false;
        }

        /* Checks if a hero is still alive,
         * else returns false and asigns 0 to health points*/
        public bool StillAlive(Hero attackedHero)
        {
            if (attackedHero.HealthPoints <= .0m)
            {
                attackedHero.HealthPoints = .0m;
                return false;
            }
            return true;
        }


        /* Checks three condition and performs an attack,
         * if a hero is dead asigns false to canAttack,
         * so an attack can no longer be performed */
        public void AttackInProgress(Hero attackingHero, Hero attackedHero)
        {
            if (ReadyToStart() && StillAlive(attackedHero) && canAttack)
            {
                attackingHero.Attack(attackedHero);
                if (!StillAlive(attackedHero))
                {
                    canAttack = false;
                }
            }
        }


        
    }
}
