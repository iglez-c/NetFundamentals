using System;

namespace NetFundamentals.DesignPatterns.Proxy
{
    /// <summary>
    /// In this example, the Subject interface defines the methods that the RealSubject and Proxy classes must implement.
    /// The RealSubject class implements the Subject interface and performs the real work.
    /// The Proxy class implements the Subject interface and forwards requests to the RealSubject class, which actually performs the work.
    ///
    /// When the Client code creates a Proxy object, it calls the Request method on the Proxy object.
    /// The Proxy object checks if it has a RealSubject object, and if not, creates one.
    /// Then the Proxy object logs the request and forwards it to the RealSubject object using the Request method.
    /// The RealSubject object handles the request and performs the real work.
    ///
    /// Using the Proxy design pattern, the Client code can make requests without knowing whether it's using the RealSubject object or the Proxy object.
    /// The Proxy object can provide additional functionality, such as logging, without affecting the way the Client code uses the RealSubject object.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code uses the Proxy class to make requests.
        public void Execute()
        {
            Console.WriteLine("--==== Proxy ====--");
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
