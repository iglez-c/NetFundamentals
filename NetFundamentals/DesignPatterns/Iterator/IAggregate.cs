namespace NetFundamentals.DesignPatterns.Iterator
{
    // The Aggregate interface defines a method that returns an Iterator object.
    public interface IAggregate
    {
        Iterator CreateIterator();
    }
}
