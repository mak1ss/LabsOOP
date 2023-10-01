using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Car
    {
        public string Model { get; }
        public Engine Engine { get; }
        public int Weight { get; }
        public string Color { get; }

        public Car(string model, Engine engine, int weight, string color)
        {

            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public Car(string model, Engine engine, int weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = "n/a";
        }

        public Car(string model, Engine engine, string color)
        {
            Model = model;
            Engine = engine;
            Color = color;
            Weight = 0;
        }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = "n/a";
        }
        public override string ToString()
        {
            string engine = Engine.ToString();
            return Model + ":\n" + "\t" + engine + "\n" + "\tWeight: " + (Weight == 0 ? "n/a" : Weight) + "\n" + "\tColor: " + Color;
        }
    }
}
