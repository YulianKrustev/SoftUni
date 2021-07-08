using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T>
        where T : IComparable<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            boxCollection = new List<T>();
        }

        public int CountGreater { get; private set; }

        public void Add(T item)
        {
            boxCollection.Add(item);
        }

        public void Compare(T element)
        {
            foreach (var item in boxCollection)
            {
                if (item.CompareTo(element) > 0 )
                {
                    CountGreater++;
                }
            }
        }

        public void Swap(int x, int y)
        {
            T elementOne = boxCollection[x];
            boxCollection[x] = boxCollection[y];
            boxCollection[y] = elementOne;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in boxCollection)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString();
        }
    }
}
