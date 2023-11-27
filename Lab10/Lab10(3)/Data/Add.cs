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
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory factory;

        public Add(string[] data)
            : base(data) { }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = factory.CreateUnit(unitType);
            repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
