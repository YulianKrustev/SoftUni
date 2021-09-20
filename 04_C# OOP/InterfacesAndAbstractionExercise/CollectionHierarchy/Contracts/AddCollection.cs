using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public class AddCollection : IAddCollection
    {
        public AddCollection()
        {
            Collection = new List<string>();
        }

        public List<string> Collection { get; }

        public int Add(string element)
        {
            Collection.Add(element);
            return Collection.Count - 1;
        }
    }
}
