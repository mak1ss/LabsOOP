using Lab07_8_.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_8_.implementations
{
    internal class SpecialisedSoldier : Soldier, ISpecialisedSoldier
    {
        
        public string Corps { get; }
        public SpecialisedSoldier(int id, string firstName, string lastName, string corps)
        : base(id, firstName, lastName)
        {
            Corps = ValidateCorps(corps);
        }     

        private static string ValidateCorps(string corps)
        {
            if (corps != "Airforces" && corps != "Marines")
            {
                throw new ArgumentException("Invalid corps");
            }
            return corps;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Corps: {Corps}";
        }
    }
}
