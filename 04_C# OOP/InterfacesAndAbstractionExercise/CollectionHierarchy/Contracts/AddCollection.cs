using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public interface AddCollection
    {
        public List<string> Collection { get; }

        public void AddCollection();
    }
}
