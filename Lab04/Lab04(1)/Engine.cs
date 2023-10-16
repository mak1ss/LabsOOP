using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Engine
    {
        public int Speed
        {
            get;
        }
        public int Power
        {
            get;
        }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
