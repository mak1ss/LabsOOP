using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_3_
{
    internal class CustomStack<T> : IEnumerable<T>

    {
        private List<T> stack;

        public CustomStack( )
        {
            stack = new List<T>();
        }
        
        public void Push(T item)
        {
            stack.Add(item);
        }

        public void Pop()
        {
            stack.RemoveAt(stack.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];  
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }
    }
}
