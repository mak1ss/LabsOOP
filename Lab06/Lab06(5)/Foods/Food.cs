using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_5_
{
    internal abstract class Food
    {
        public int PointsAmount 
        { 
            get;
            protected set;
        }

        protected Food (int pointsAmount)
        {
            this.PointsAmount = pointsAmount;
        }
    }
}
