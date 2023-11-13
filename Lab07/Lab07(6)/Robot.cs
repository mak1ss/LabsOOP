using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_6_
{
    internal class Robot : IIdentifiable
    {
        public string Model {  get; private set; }
        public long Id { get; set; }

        public Robot(string model, long id)
        {
            Model = model;
            Id = id;
        }
    }
}
