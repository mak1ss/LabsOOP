using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Data
{
    class Report : Command
    {
        public Report(string[] data, IRepository repository, IUnitFactory factory) 
            : base(data, repository, factory) { }

        public override string Execute()
        {
            string output = Repository.Statistics;
            return output;
        }
    }
}
