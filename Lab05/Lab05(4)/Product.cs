using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_4_
{
    internal class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            SetName(name);
            SetCost(cost);
        }

        private void SetName(string name)
        {
            if (String.IsNullOrEmpty(name.Trim()))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = name;
        }
        
        private void SetCost(int cost)
        {
            if(cost < 0)
            {
                throw new ArgumentException("Cost cannot be negative");
            }
            this.cost = cost;
        }

        public string GetName() { return name; }

        public int GetCost() { return cost; }   
    }
}
