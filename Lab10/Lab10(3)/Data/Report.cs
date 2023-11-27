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
        [Inject]
        private IRepository repository;

        public Report(string[] data) 
            : base(data) { }

        public override string Execute()
        {
            string output = repository.Statistics;
            return output;
        }
    }
}
