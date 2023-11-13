using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_7_
{
    internal interface IBuyer
    {
        public string Name { get; set; }
        public int Food { get; set; } 

        void BuyFood();
    }
}
