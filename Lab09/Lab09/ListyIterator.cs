using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;

        private int position = 0;

        public bool HasNext
        {
            get
            {
                return position < collection.Count - 1;
            }
        }

        public ListyIterator(List<T> collection)
        {
            this.collection = collection;
        }

        public bool MoveNext()
        {
            if (HasNext)
            {
                position++;
                return true;
            } 
            return false;
        }

        public void Print()
        {
            if (collection.Count == 1)
            {
                throw new ArgumentException("Invalid operation!");
            }
            Console.WriteLine(collection[position]);
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach(T item in collection)
            {
                yield return item;
            }
        }
    }
}
