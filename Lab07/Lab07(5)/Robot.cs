using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_5_
{
    internal class Robot : Entity
    {
        public string Model {  get; private set; }


        public Robot(string model, long id)
        {
            Model = model;
            base.Id = id;
        }
    }
}
