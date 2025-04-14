using System;

namespace NetFundamentals.DesignPatterns.Adapter
{
    /// <summary>
    /// In this example, the Target interface defines the domain-specific interface that the Client uses.
    /// The Adaptee class is the class that needs to be adapted to the Target interface.
    /// The Adapter class adapts the Adaptee to the Target interface by implementing the Target interface and
    /// using an instance of the Adaptee class to perform the work.
    /// Finally, the Client uses the Target interface to call the Request method, which is actually implemented by the Adaptee class via the Adapter class.
    /// </summary>
    public class ExampleUsage
    {
        // The Client uses the Target interface to call the Request method.
        public void Execute()
        {
            Console.WriteLine("--==== Adapter ====--");
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            target.Request();
        }
    }
}
