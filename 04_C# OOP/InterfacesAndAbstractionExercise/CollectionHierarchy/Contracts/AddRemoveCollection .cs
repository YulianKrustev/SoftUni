using System.Collections.Generic;

namespace CollectionHierarchy.Contracts
{
    public interface AddRemoveCollection : AddCollection
    {
        public void Remove();
    }
}
