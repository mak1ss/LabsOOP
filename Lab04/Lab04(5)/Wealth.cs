using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Wealth
    {
        public int quantity { get; set; }

        public Wealth(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity() { return quantity; }
    }

}
