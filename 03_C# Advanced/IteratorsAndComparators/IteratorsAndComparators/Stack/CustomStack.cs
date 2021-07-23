using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public CustomStack()
        {
            collection = new List<T>();
        }

        public void Push(T[] elemnts)
        {
            foreach (var elemnt in elemnts)
            {
                collection.Add(elemnt);
            }
        }

        public T Pop()
        {
            if (collection.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            var element = collection[collection.Count - 1];
            collection.RemoveAt(collection.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
