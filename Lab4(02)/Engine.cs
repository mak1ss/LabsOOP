using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Engine
    {
        public string Model { get; }
        public int Power { get; }
        public int Displacement { get; }
        public string Efficiency { get; }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = "n/a";
        }

        public Engine(string model, int power, string efficiency)
        {
            Model = model;
            Power = power;
            Efficiency = efficiency;
            Displacement = 0;
        }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Displacement = 0;
            Efficiency = "n/a";
        }

        public override string ToString()
        {
            return Model + ":\n" + "\t\tPower: " + Power + "\n" + "\t\tDisplacement: " + (Displacement == 0 ? "n/a" : Displacement) + "\n" + "\t\tEfficiency: " + Efficiency;
        }
    }
}
