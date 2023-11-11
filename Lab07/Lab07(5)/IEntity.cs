using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_5_
{
    internal interface IEntity
    {
        public long Id { get; protected set; }
    }
}
