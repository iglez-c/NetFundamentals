using System;

namespace NetFundamentals.DesignPatterns.Bridge
{
    /// <summary>
    /// In this example, the Implementor interface defines the interface for concrete implementors.
    /// The ConcreteImplementorA and ConcreteImplementorB classes are concrete implementors that implement the Implementor interface.
    /// The Abstraction class defines the interface for the Abstraction part of the bridge and contains a reference to an IImplementor object.
    /// The RefinedAbstraction class extends the Abstraction interface and delegates to the Implementor interface.
    /// Finally, the Client uses the Abstraction interface to call the Operation method,
    /// which is actually implemented by the ConcreteImplementor classes via the RefinedAbstraction class.
    /// </summary>
    public class ExampleUsage
    {
        // The Client uses the Abstraction interface to call the Operation method.
        public void Execute()
        {
            Console.WriteLine("--==== Bridge ====--");
            IImplementor implementorA = new ConcreteImplementorA();
            IImplementor implementorB = new ConcreteImplementorB();

            Abstraction abstractionA = new RefinedAbstraction(implementorA);
            abstractionA.Operation();

            Abstraction abstractionB = new RefinedAbstraction(implementorB);
            abstractionB.Operation();
        }
    }
}
