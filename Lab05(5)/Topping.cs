using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_5_
{
    internal enum ToppingType
    {
        meat, veggies, cheese, sauce
    }
    internal class Topping
    {
        private int weight;
        private ToppingType type;

        public Topping(string type, int weight)
        {
            SetType(type);
            SetWeight(weight);
        }

        private void SetType(string type)
        {
            if (!Enum.IsDefined(typeof(ToppingType), type))
            {
                throw new ArgumentException(String.Format("Cannot place {0} on top of your pizza", type));
            }
            this.type = (ToppingType)Enum.Parse(typeof(ToppingType), type);
        }

        private void SetWeight(int weight)
        {
            if (weight < 1 || weight > 50)
            {
                throw new ArgumentException(String.Format("{0} weight should be in the range [1...50]", type));
            }
            this.weight = weight;
        }

        public float CalcCalories()
        {
            float calories = weight * 2;
            switch (type)
            {
                case ToppingType.meat:
                    calories *= (float)1.2;
                    break;
                case ToppingType.veggies:
                    calories *= (float)0.8;
                    break;
                case ToppingType.cheese:
                    calories *= (float)1.1;
                    break;
                case ToppingType.sauce:
                    calories *= (float)0.9;
                    break;
            }
            return calories;
        }
    }
}
