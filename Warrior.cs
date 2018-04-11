using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanVGame
{
    class Warrior : Hero
    {
        public override decimal AttackPoints { get { return 150.0m; } } 
        public override decimal ArmorPoints { get { return 80.0m; } }
    }
}
