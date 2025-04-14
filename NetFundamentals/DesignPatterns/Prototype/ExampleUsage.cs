using System;

namespace NetFundamentals.DesignPatterns.Prototype
{
    /// <summary>
    /// In this example, the Prototype interface defines a Clone() method that creates a shallow copy of the object.
    /// The ConcretePrototype class implements the Prototype interface and provides its own implementation of the Clone()
    /// method using the MemberwiseClone() method to create a copy of itself.
    /// Finally, the Client class demonstrates how to use the Prototype to create and clone objects.
    /// Two ConcretePrototype objects are created, the second one being a clone of the first one.
    /// The values of the cloned object are modified, showing that the two objects are separate instances.
    /// </summary>
    public class ExampleUsage
    {
        // The Client class demonstrates how to use the Prototype to clone objects.
        public void Execute()
        {
            Console.WriteLine("--==== Prototype ====--");
            ConcretePrototype prototype1 = new ConcretePrototype { Id = 1, Name = "Prototype 1" };
            ConcretePrototype prototype2 = prototype1.Clone();
            prototype2.Id = 2;
            prototype2.Name = "Prototype 2";

            Console.WriteLine("Prototype 1: " + prototype1);
            Console.WriteLine("Prototype 2: " + prototype2);
        }
    }
}
