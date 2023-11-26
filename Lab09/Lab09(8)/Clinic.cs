using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_8_
{
    internal class Clinic
    {
        public string Name { get; private set; }
        private List<Pet> pets;
        private int centralIndex;
        private int emptyRooms;
        public Clinic(string name, int rooms)
        {
            Name = name;
            if (rooms % 2 == 0)
            {
                throw new ArgumentException("Invalid number of rooms");
            }
            pets = new List<Pet>(rooms);
            centralIndex = rooms / 2;
            emptyRooms = rooms;
        }

        public bool Add(Pet pet)
        {
            emptyRooms--;
            return false;
        }

        public bool Release()
        {
            emptyRooms++;
            return false;
        }

        public bool HasEmptyRooms()
        {
            return emptyRooms > 0;
        }
        
        public void Print()
        {

        }

        public void Print(int room)
        {

        }
    }
}
