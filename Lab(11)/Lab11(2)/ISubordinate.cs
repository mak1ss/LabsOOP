using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_
{
    public delegate void SubordinateKilledHandler(ISubordinate sender);
    public interface ISubordinate
    {
        public string Name { get; set; }

        public void OnKingAttack();
        public void ReceiveHit();
        
        public event SubordinateKilledHandler SubordinateKilled;
    }
}
