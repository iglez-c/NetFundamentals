using System;

namespace NetFundamentals.DesignPatterns.ChainOfResponsibility
{
    /// <summary>
    /// In this example, the Handler abstract class defines the interface for handling requests and provides a reference to the next handler in the chain.
    /// The ConcreteHandler1, ConcreteHandler2, and ConcreteHandler3 classes are concrete implementations of the Handler class.
    /// They each handle requests that fall within a specific range of values.
    ///
    /// The Client code creates a chain of handlers and sends requests to the first handler in the chain.
    /// The first handler in the chain checks if it can handle the request.If it can, it handles the request.
    /// If not, it passes the request to the next handler in the chain.
    /// This process continues until a handler can handle the request or until the end of the chain is reached.
    ///
    /// Using the Chain of Responsibility design pattern, the Client code can send requests without knowing which handler will handle the request.
    /// Each handler in the chain only knows how to handle requests within a specific range of values.
    /// If a new handler needs to be added to the chain, the existing handlers don't need to be modified.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code creates a chain of handlers and sends requests to the first handler in the chain.
        public void Execute()
        {
            Console.WriteLine("--==== ChainOfReponsibility ====--");
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();

            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(handler3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                handler1.HandleRequest(request);
            }
        }
    }
}
