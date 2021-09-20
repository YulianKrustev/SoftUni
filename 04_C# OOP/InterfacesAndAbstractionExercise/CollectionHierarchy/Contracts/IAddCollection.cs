using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public interface IAddCollection
    {
        public List<string> Collection { get; }

        public int Add(string element);
    }
}
