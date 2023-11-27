using _03BarracksFactory.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Models.Units
{
    internal class Horseman : Unit
    {
        private const int DefaultHealth = 25;
        private const int DefaultDamage = 7;

        public Horseman()
            : base(DefaultHealth, DefaultDamage) { }
        
    }
}
