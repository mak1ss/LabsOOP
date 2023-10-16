using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Tire
    {
        public int Age
        {
            get;
        }
        public double Pressure
        {
            get;
        }

        public Tire(double pressure, int age)
        {
            Age = age;
            Pressure = pressure;
        }

    }
}
