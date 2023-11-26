using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_
{
    public delegate void OnAttackKingEventHanlder();
    internal class King
    {
        public string Name { get; set; }

        public King(string name)
        {
            this.Name = name;
        }

        public event OnAttackKingEventHanlder AttackKing;

        public void Attack()
        {
            Console.WriteLine($"King {Name} is under attack");
            OnAttack();
        }

        private void OnAttack()
        {
            AttackKing?.Invoke();
        }

        public void OnSubordinateKilled(ISubordinate sender)
        {
            AttackKing -= sender.OnKingAttack;
        }
    }
}
