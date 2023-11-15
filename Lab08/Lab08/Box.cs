using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Box <T> : IComparable<Box<T>> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Box (T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }

        public int CompareTo(Box<T> box)
        {
            if(this == box) return 0 ;
            if(box == null) return -1 ;
            return this.Value.CompareTo(box.Value);
        }
    }
}
