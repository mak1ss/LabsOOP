using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab06_5_.Factories.Abstractions
{
    internal abstract class FoodFactory
    {
        public abstract Food GetFood(string name);

    }
}
