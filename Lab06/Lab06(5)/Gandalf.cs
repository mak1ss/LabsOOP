using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06_5_.Factories.Abstractions;
using Lab06_5_.Factories.Implementations;

namespace Lab06_5_
{
    internal class Gandalf
    {
        private MoodFactory factory = new MoodFactoryImpl();
        public int happines
        {
            get;
            private set;
        }

        public void Feed(Food food)
        {
            happines += food.PointsAmount;
        }

        public Mood GetMood()
        {
            return factory.GetMood(happines);
        }
    }
}
