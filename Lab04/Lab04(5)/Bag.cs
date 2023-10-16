using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Bag
    {
        private int capacity;
        private int currentAmount;
        private int gold = 0;
        private HashSet<Gem> gems = new HashSet<Gem>();
        private HashSet<Cash> cash = new HashSet<Cash>();

        public Bag(int capacity)
        {
            this.capacity = capacity;
            currentAmount = 0;
        }

        public bool addGold(Gold g)
        {
            if (g.GetQuantity() + currentAmount > capacity)
            {
                currentAmount = (g.quantity + currentAmount) - capacity;
                return false;
            }
            currentAmount += g.quantity;
            gold += g.quantity;
            return true;
        }
        public bool addGems(Gem g)
        {
            if (g.GetQuantity() + currentAmount > capacity)
            {
                currentAmount = (g.quantity + currentAmount) - capacity;
                return false;
            }
            int gemQuantity = gems.AsQueryable().Sum(gem => gem.GetQuantity());
            if (g.GetQuantity() + gemQuantity > gold)
            {
                return false;
            }
            if (gems.AsQueryable().Any(gem => gem.name.Equals(g.name)))
            {
                foreach (Gem i in gems)
                {
                    if (i.name.Equals(g.name))
                    {
                        i.quantity += g.quantity;
                        break;
                    }
                }
            }
            gems.Add(g);
            currentAmount += g.quantity;
            return true;
        }
        public bool addCash(Cash c)
        {
            if (c.GetQuantity() + currentAmount > capacity)
            {
                currentAmount = (c.quantity + currentAmount) - capacity;
                return false;
            }
            int gemQuantity = gems.AsQueryable().Sum(gem => gem.GetQuantity());
            int cashQuantity = cash.AsQueryable().Sum(cash => cash.GetQuantity());
            if (cashQuantity + c.quantity > gemQuantity)
            {
                return false;
            }

            if (cash.AsQueryable().Any(cash => cash.name.Equals(c.name)))
            {
                foreach (Cash i in cash)
                {
                    if (i.name.Equals(c.name))
                    {
                        i.quantity += c.quantity;
                        break;
                    }
                }
            }
            currentAmount += c.quantity;
            cash.Add(c);
            return true;
        }

        public override string ToString()
        {
            string result = "";
            if (gold != 0)
            {
                result += String.Format("<Gold> ${0}\n##Gold - {1}\n", gold, gold);
            }
            if (gems.Count() > 0)
            {
                gems = gems.AsQueryable().OrderByDescending(g => g.name).ThenBy(g => g.quantity).ToHashSet();
                result += String.Format("<Gems> ${0}\n", gems.AsQueryable().Sum(gem => gem.GetQuantity()));
                foreach (Gem gem in gems)
                {
                    result += String.Format("##{0} - {1}\n", gem.name, gem.quantity);
                }
            }
            if (cash.Count() > 0)
            {
                cash = cash.AsQueryable().OrderByDescending(c => c.name).ThenBy(c => c.quantity).ToHashSet();
                result += String.Format("<Cash> ${0}\n", cash.AsQueryable().Sum(cash => cash.GetQuantity()));
                foreach (Cash c in cash)
                {
                    result += String.Format("##{0} - {1}\n", c.name, c.quantity);
                }
            }
            return result;
        }

    }
}
