using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_8_
{
    internal class CustomListEnumerator<T> : IEnumerator<T>
    {
        public T[] dynamicArray;

        int position = -1;

        public CustomListEnumerator(T[] dynamicArray)
        {
            this.dynamicArray = dynamicArray;
        }

        public object Current
        {
            get
            {
                try
                {
                    return dynamicArray[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                return (T)Current;
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            position++;
            return position < dynamicArray.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
