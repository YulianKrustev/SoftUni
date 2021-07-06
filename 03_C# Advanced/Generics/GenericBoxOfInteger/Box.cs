using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            boxCollection = new List<T>();
        }

        public void Add(T item)
        {
            boxCollection.Add(item);
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