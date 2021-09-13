namespace CollectionHierarchy.Contracts
{
    interface MyList : AddRemoveCollection
    {
        public int Used => Collection.Count;
    }
}
