using System;

namespace NetFundamentals.DesignPatterns.Flyweight
{
    /// <summary>
    /// In this example, the Flyweight interface defines the methods that the ConcreteFlyweight and UnsharedConcreteFlyweight classes must implement.
    /// The ConcreteFlyweight class implements the Flyweight interface and stores intrinsic state. The FlyweightFactory class creates and
    /// manages Flyweight objects, and ensures that Flyweight objects are shared properly.
    /// The UnsharedConcreteFlyweight class implements the Flyweight interface and stores unshared intrinsic state.
    /// The Client code uses the FlyweightFactory to get and use Flyweight objects.
    ///
    /// When the Client code gets a Flyweight object from the FlyweightFactory, it calls the Operation method on the Flyweight object,
    /// passing in an extrinsic state.The Flyweight object uses its intrinsic state and the extrinsic state to perform some operation.
    ///
    /// When the Client code creates an UnsharedConcreteFlyweight object, it also calls the Operation method on the UnsharedConcreteFlyweight object,
    /// passing in an extrinsic state.
    /// The UnsharedConcreteFlyweight object uses its unshared intrinsic state and the extrinsic state to perform some operation.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code uses the FlyweightFactory to get and use Flyweight objects.
        public void Execute()
        {
            Console.WriteLine("--==== Flyweight ====--");
            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight flyweight1 = factory.GetFlyweight("key1");
            flyweight1.Operation(1);

            IFlyweight flyweight2 = factory.GetFlyweight("key2");
            flyweight2.Operation(2);

            IFlyweight flyweight3 = factory.GetFlyweight("key1");
            flyweight3.Operation(3);

            IFlyweight unsharedFlyweight = new UnsharedConcreteFlyweight("unshared");
            unsharedFlyweight.Operation(4);
        }
    }
}
