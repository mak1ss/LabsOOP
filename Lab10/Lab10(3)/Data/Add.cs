using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Data
{
    class Add : Command
    {
        public Add(string[] data, IRepository repository, IUnitFactory factory)
            : base(data, repository, factory) { }
        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = Factory.CreateUnit(unitType);
            Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
