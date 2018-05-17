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

        /* Initializes type of hero depending on character parameter */
        public Hero InitializeHero(char ch)
        {
            Hero hero = null;
            switch (ch)
            {
                case 'w':
                    hero = new Warrior();
                    break;
                case 'k':
                    hero = new Knight();
                    break;
                case 'a':
                    hero = new Assassin();
                    break;
                case 'm':
                    hero = new Monk();                 
                    break;
                case 'c':
                    hero = new Clumsy();                    
                    break;
            }
            return hero;
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


        /* Checks three condition and performs an attack,
         * if a hero is dead asigns false to canAttack,
         * so an attack can no longer be performed */
        public void AttackInProgress(Hero attackingHero, Hero attackedHero)
        {
            if (ReadyToStart() && attackedHero.StillAlive() && canAttack)
            {
                attackingHero.Attack(attackedHero);
                if (!attackedHero.StillAlive())
                {
                    canAttack = false;
                }
            }
        }


        
    }
}
