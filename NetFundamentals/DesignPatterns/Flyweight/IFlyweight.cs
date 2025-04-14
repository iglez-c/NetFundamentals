namespace NetFundamentals.DesignPatterns.Flyweight
{
    // The Flyweight interface defines the methods that the ConcreteFlyweight and UnsharedConcreteFlyweight classes must implement.
    public interface IFlyweight
    {
        void Operation(int extrinsicState);
    }
}
