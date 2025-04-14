using System;

namespace NetFundamentals.DesignPatterns.Decorator
{
    /// <summary>
    /// In this example, the Component abstract class defines the interface for objects that can have responsibilities added to them dynamically.
    /// The ConcreteComponent class represents the objects that can have responsibilities added to them dynamically.
    /// The Decorator abstract class maintains a reference to a Component object and defines an interface that conforms to Component's interface.
    /// The ConcreteDecoratorA and ConcreteDecoratorB classes add responsibilities to the object dynamically.
    /// 
    /// The Client code creates a ConcreteComponent object and then decorates it with ConcreteDecoratorA and ConcreteDecoratorB objects.
    /// The decorator objects add new behavior to the original object by calling the Operation method on the decorated object and adding
    /// their own behavior before or after the call to the original object's Operation method.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code creates a ConcreteComponent object and then decorates it with ConcreteDecoratorA and ConcreteDecoratorB objects.
        public void Execute()
        {
            Console.WriteLine("--==== Decorator ====--");

            // Create a ConcreteComponent object
            ConcreteComponent component = new ConcreteComponent();

            // Decorate the ConcreteComponent object with ConcreteDecoratorA and ConcreteDecoratorB objects
            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(component);
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);

            // Call the Operation method on the decorated object
            decoratorB.Operation();
        }
    }
}
