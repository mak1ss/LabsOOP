using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Car
    {
        public Model Model
        {
            get;
        }
        public Cargo Cargo
        {
            get;
        }
        public Engine Engine
        {
            get;
        }
        public List<Tire> Tires
        {
            get;
        }

        public Car(Model model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public Car()
        { }

        public override string ToString()
        {
            string res = Model.Name + " " + Engine.Speed + " " + Engine.Power + " " + Cargo.Weight + " " + Cargo.Type;
            foreach (Tire tire in Tires)
            {
                res.Concat(" " + tire.ToString());
            }
            return res;
        }
    }
}
