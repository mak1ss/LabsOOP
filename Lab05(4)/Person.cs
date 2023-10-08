using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_4_
{
    internal class Person
    {
        private string name;
        private int money;
        private List<Product> productsBag = new List<Product>();
        public Person(string name, int money)
        {
            SetMoney(money);
            SetName(name);
        }

        private void SetName(string name)
        {
            if (String.IsNullOrEmpty(name.Trim()))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = name;
        }

        private void SetMoney(int money)
        {
            if (money < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = money;
        }

        public bool AddProduct(Product product)
        {
            if (product.GetCost() > money)
            {
                return false;
            }

            money = money - product.GetCost();
            productsBag.Add(product);
            return true;
        }

        public override string ToString()
        {
            string result = name + " - ";
            if(productsBag.Count > 0)
            {
                foreach(Product product in productsBag)
                {
                    result += product.GetName();
                }
            } else
            {
                result += "Nothing bought";
            }

            return result;
        }
    }
}
