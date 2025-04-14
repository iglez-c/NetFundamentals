using System;

namespace NetFundamentals.DesignPatterns.Mediator
{
    /// <summary>
    /// In this example, the IMediator interface defines the methods that a mediator must implement,
    /// and the IColleague interface defines the methods that a colleague must implement.
    /// The ConcreteMediator class implements the IMediator interface and mediates communication between colleagues.
    /// The ConcreteColleague1 and ConcreteColleague2 classes implement the IColleague interface and communicate with other colleagues through the mediator.
    ///
    /// The Client code creates a ConcreteMediator object and registers ConcreteColleague1 and ConcreteColleague2 objects with it
    /// using the Colleague1 and Colleague2 properties. It then sends messages between the colleagues using the Send() method.
    /// When a colleague sends a message, the mediator's Notify() method is called,
    /// which relays the message to the other colleague using its Receive() method.
    ///
    /// Using the Mediator design pattern, the Client code can mediate communication between objects in a flexible and
    /// decoupled way by defining new classes that implement the IMediator and...
    /// </summary>
    public class ExampleUsage
    {
        // The Client code creates a ConcreteMediator object and registers ConcreteColleague1 and ConcreteColleague2 objects with it. It then sends messages between the colleagues using the Send() method.
        public void Execute()
        {
            Console.WriteLine("--==== Mediator ====--");
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("Hello from ConcreteColleague1!");
            colleague2.Send("Hello from ConcreteColleague2!");
        }
    }
}
