using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_5_
{
    internal enum BakingTechnique
    {
        crispy, chewy, homemade
    }
    internal enum FlourType
    {
        white, wholegrain
    }
    internal class Dough
    {
        private int weight;
        private BakingTechnique technique;
        private FlourType flour;

        public Dough(string flour, string technique, int weight)
        {   
            SetFlour(flour);
            SetBaking(technique);
            SetWeight(weight);            
        }

        private void SetBaking(string technique)
        {
            if (!Enum.IsDefined(typeof(BakingTechnique), technique))
            {
                throw new ArgumentException("Invalid type of dough");
            }
            this.technique = (BakingTechnique)Enum.Parse(typeof(BakingTechnique), technique);
        }

        private void SetFlour(string flour)
        {
            if (!Enum.IsDefined(typeof(FlourType), flour))
            {
                throw new ArgumentException("Invalid type of dough");
            }
            this.flour = (FlourType)Enum.Parse(typeof(FlourType), flour);
        }

        private void SetWeight(int weight)
        {
            if (weight < 1 | weight > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200]");
            }
            this.weight = weight;
        }

        public float CalcCalories()
        {
            float calories = weight * 2;
            switch (technique)
            {
                case BakingTechnique.chewy:
                    calories *= (float)1.1;
                    break;
                case BakingTechnique.crispy:
                    calories *= (float)0.9;
                    break;
            }
            switch (flour)
            {
                case FlourType.white:
                    calories *= (float)1.5;
                    break;
            }
            return calories;
        }
    }
}
