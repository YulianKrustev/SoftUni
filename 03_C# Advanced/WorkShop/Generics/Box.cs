using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        List<T> list;
        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            if (Count != 0)
            {
                T element = list[Count - 1];
                list.RemoveAt(Count - 1);
                return element;
            }

            throw new InvalidOperationException("Can not remove element! The list is empty!");
        }
    }
}
