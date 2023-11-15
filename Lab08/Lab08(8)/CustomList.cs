using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_8_
{
    public class CustomList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private T[] dynamicArray = new T[16];
        private int threshold = (int)(16 * 0.75);
        public int Size { get; private set; }
        public void Add(T item)
        {
            if (Size == threshold)
            {
                EnsureCapacity();
            }
            dynamicArray[Size++] = item;
        }

        private void EnsureCapacity()
        {
            Array.Resize(ref dynamicArray, (int)(dynamicArray.Length * 1.5));
            threshold = (int)(dynamicArray.Length * 0.75);
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= Size)
            {
                throw new ArgumentException("Inalid index!");
            }
            T removed = dynamicArray[index];
            for (int i = index; i < Size; i++)
            {
                dynamicArray[i] = dynamicArray[i + 1];
            }
            return removed;
        }

        public bool Contains(T item)
        {
            foreach (T value in dynamicArray)
            {
                if (value.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            if ((index1 < 0 || index2 < 0) || (index1 >= Size || index2 >= Size))
            {
                throw new ArgumentException("Invalid index!");
            }
            T temp = dynamicArray[index1];
            dynamicArray[index1] = dynamicArray[index2];
            dynamicArray[index2] = temp;
        }

        public int CountGreaterThan(T value)
        {
            int count = 0;
            Array.ForEach(dynamicArray, item =>
            {
                if (item != null && item.CompareTo(value) > 0)
                {
                    count++;
                }
            });
            return count;
        }

        public T? Max()
        {
            return dynamicArray.Max();
        }

        public T? Min()
        {
            return dynamicArray.Min();
        }

        public void Sort()
        {
            Array.Sort(dynamicArray);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (T item in this)
            {
                if (i++ < Size)
                {
                    builder.Append($"[ {item} ]");
                } else
                {
                    break;
                }
            }
            return builder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomListEnumerator<T>(dynamicArray);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CustomListEnumerator<T>(dynamicArray);
        }
    }
}
