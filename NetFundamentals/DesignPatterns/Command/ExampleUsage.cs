using System;

namespace NetFundamentals.DesignPatterns.Command
{
    /// <summary>
    /// In this example, the Command interface defines the interface for executing commands.
    /// The Receiver class defines the object that the commands will act upon.
    /// The ConcreteCommand class implements the ICommand interface and holds a reference to the Receiver object.
    /// The Invoker class holds a reference to the ICommand object and calls its Execute() method.
    ///
    /// The Client code creates a Receiver object, a ConcreteCommand object, and an Invoker object.
    /// It sets the ConcreteCommand object as the command to be executed by the Invoker object and then calls the ExecuteCommand() method.
    /// When the ExecuteCommand() method is called, the Invoker object calls the Execute() method of the ConcreteCommand object,
    /// which in turn calls the Action() method of the Receiver object.
    ///
    /// Using the Command design pattern, the Client code can create objects that encapsulate commands and pass them to other objects
    /// without knowing the specifics of the commands or the receivers.This allows for more flexible and decoupled code.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code creates a Receiver object, a ConcreteCommand object, and an Invoker object. It sets the ConcreteCommand object as the command to be executed by the Invoker object and then calls the ExecuteCommand() method.
        public void Execute()
        {
            Console.WriteLine("--==== Command ====--");
            Receiver receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
