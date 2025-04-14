namespace NetFundamentals.DesignPatterns.Iterator
{
    // The Iterator interface defines the methods that an iterator must implement.
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
