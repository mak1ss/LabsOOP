using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_
{
    
    internal class RoyalGuard : ISubordinate
    {
        public event SubordinateKilledHandler SubordinateKilled;
        private int hitsReceived;
        public string Name { get; set; }

        public RoyalGuard(string name, King king)
        {
            this.Name = name;
            king.AttackKing += OnKingAttack;
        }

        public void ReceiveHit()
        {
            hitsReceived++;
            if (hitsReceived == 3)
            {
                OnSubordinateKilled();
            }
        }

        public void OnKingAttack()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }

        public void OnSubordinateKilled()
        {
            SubordinateKilled?.Invoke(this);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
