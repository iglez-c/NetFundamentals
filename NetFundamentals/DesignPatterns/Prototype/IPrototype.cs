namespace NetFundamentals.DesignPatterns.Prototype
{
    // The Prototype interface defines a method for cloning itself.
    public interface IPrototype<T>
    {
        T Clone();
    }
}
