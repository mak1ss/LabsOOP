using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06_5_.Factories.Abstractions;
using Lab06_5_.Foods;

namespace Lab06_5_.Factories.Implementations
{
    internal class FoodFactoryImpl : FoodFactory
    {
        public override Food GetFood(string name)
        {
            switch (name)
            {
                case "cram":
                    return new Cram();
                    break;

                case "apple":
                    return new Apple();
                    break;

                case "lembas": 
                    return new Lembas();
                    break;

                case "melon":
                    return new Melon();
                    break;

                case "honeycake":
                    return new HoneyCake();
                    break;

                default:
                    return new DefaultFood();
            }
        }
    }
}
