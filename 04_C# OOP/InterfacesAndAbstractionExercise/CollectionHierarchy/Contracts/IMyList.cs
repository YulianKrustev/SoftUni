namespace CollectionHierarchy.Contracts
{
    public interface IMyList : IAddRemoveCollection
    {
        public int Used { get; }
    }
}
