using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BarracksFactory.Data
{
    abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory factory;

        protected Command(string[] data, IRepository repository, IUnitFactory factory)
        {
            this.data = data;
            this.repository = repository;
            this.factory = factory;
        }

        protected string[] Data
        {
            get { return data; }
            private set => data = value;
        }

        protected IRepository Repository
        {
            get { return repository; }
            private set => repository = value;
        }

        protected IUnitFactory Factory
        {
            get { return factory; }
            private set => factory = value;
        }

        public abstract string Execute();

    }
}
