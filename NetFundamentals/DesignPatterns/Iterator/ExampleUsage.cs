using System;

namespace NetFundamentals.DesignPatterns.Iterator
{
    /// <summary>
    /// In this example, the IAggregate interface defines a method that returns an Iterator object.
    /// The Iterator interface defines the methods that an iterator must implement.
    /// The ConcreteAggregate class implements the IAggregate interface and creates an Iterator object.
    /// The ConcreteIterator class implements the Iterator interface and provides the iteration behavior for the ConcreteAggregate object.
    ///
    /// The Client code uses the ConcreteAggregate and ConcreteIterator classes to iterate over a collection of items.
    /// It creates a ConcreteAggregate object and adds items to it using the AddItem() method.
    /// It then creates an Iterator object using the CreateIterator() method and uses it to iterate over the items in
    /// the ConcreteAggregate object using the HasNext() and Next() methods.
    ///
    /// Using the Iterator design pattern, the Client code can iterate over collections of items in a flexible and extensible way by
    /// defining new classes that implement the IAggregate and Iterator interfaces.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code uses the ConcreteAggregate and ConcreteIterator classes to iterate over a collection of items.
        public void Execute()
        {
            Console.WriteLine("--==== Iterator ====--");
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate.AddItem("Item 1");
            aggregate.AddItem("Item 2");
            aggregate.AddItem("Item 3");

            Iterator iterator = aggregate.CreateIterator();

            while (iterator.HasNext())
            {
                string item = (string)iterator.Next();
                Console.WriteLine(item);
            }
        }
    }
}
