﻿using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        public AddRemoveCollection()
        {
            Collection = new List<string>();
        }

        public List<string> Collection { get; }

        public int Add(string element)
        {
            Collection.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string elementForRemove = Collection[Collection.Count - 1];
            Collection.RemoveAt(Collection.Count - 1);
            return elementForRemove;
        }
    }
}
