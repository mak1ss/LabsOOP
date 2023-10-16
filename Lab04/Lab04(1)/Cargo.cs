using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Cargo
    {
        internal int Weight
        {
            get;
        }
        public string Type
        {
            get;
        }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
