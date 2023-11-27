using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Data
{
    class Retire : Command
    {
        public Retire(string[] data, IRepository repository, IUnitFactory factory)
            : base(data, repository, factory) { }
        public override string Execute()
        {
            string unitType = Data[1];
            Repository.RemoveUnit(unitType);
            string output = unitType + " retired!";
            return output;
        }
    }
}
