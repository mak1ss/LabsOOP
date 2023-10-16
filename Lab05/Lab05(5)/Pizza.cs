using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_5_
{
    internal class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings = new List<Topping>();

        public Pizza(string name, Dough dough)
        {
            SetName(name);
            this.dough = dough;
        }

        public void AddTopping(Topping topping)
        {   
            if(toppings.Count == 10)
            {
                throw new ArgumentOutOfRangeException("Number of toppings should be in range [0..10]");
            }
            toppings.Add(topping); 
        }
        
        public float CalcTotalCalories()
        {
            float totalCalories = dough.CalcCalories();
            toppings.ForEach(topping => totalCalories += topping.CalcCalories());
            return totalCalories;
        }

        private void SetName(string name)
        {
            if (name.Length < 1 || name.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols");
            }
            this.name = name;
        }

        public int GetNumberOfToppings()
        {
            return toppings.Count;
        }

        public string GetName()
        {
            return name;
        }
    }
}
