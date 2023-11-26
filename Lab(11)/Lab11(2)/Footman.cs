using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_
{
    internal class Footman : ISubordinate
    {
        public event SubordinateKilledHandler SubordinateKilled;
        public string Name { get; set; }
        private int hitsReceived;

        public Footman(string name, King king)
        {
            Name = name;
            king.AttackKing += OnKingAttack;
        }

        public void ReceiveHit()
        {
            hitsReceived++;
            if(hitsReceived ==2)
            {
                OnSubordinateKilled();
            }
        }

        public void OnKingAttack()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
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
