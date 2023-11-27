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
        [Inject]
        private IRepository repository;

        public Retire(string[] data)
            : base(data) { }
        public override string Execute()
        {
            string unitType = Data[1];
            repository.RemoveUnit(unitType);
            string output = unitType + " retired!";
            return output;
        }
    }
}
