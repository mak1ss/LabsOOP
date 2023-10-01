using Lab04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Cash : Wealth
    {
        public string name { get; }
        public Cash(int quantity, string name) : base(quantity)
        {
            this.name = name;
        }
    }
}
