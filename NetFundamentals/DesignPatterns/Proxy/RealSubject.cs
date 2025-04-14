using System;

namespace NetFundamentals.DesignPatterns.Proxy
{
    // The RealSubject class implements the Subject interface and performs the real work.
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling request.");
        }
    }
}
