using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_3_
{
    internal class Ferrari : IFerrari
    {
        public string Model { get; private set; }
        public string Driver { get; private set; }

        public Ferrari(string model, string driver) 
        {
            Model = model;
            Driver = driver;
        }
        public string Gas() 
        {
            return "Zadu6avam sA!";
        }

        public string Break()
        {
            return "Breaks!";
        }
    }
}
