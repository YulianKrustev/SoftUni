using System;
using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public class MyList : IMyList
    {
        public MyList()
        {
            Collection = new List<string>();
        }

        public List<string> Collection { get; }

        public int Used => Collection.Count;

        public int Add(string element)
        {
            Collection.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string elementForRemove = Collection[0];
            Collection.RemoveAt(0);
            return elementForRemove;
        }
    }
}
