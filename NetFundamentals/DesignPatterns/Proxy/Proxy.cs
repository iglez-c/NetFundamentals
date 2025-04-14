using System;

namespace NetFundamentals.DesignPatterns.Proxy
{
    // The Proxy class implements the Subject interface and forwards requests to the RealSubject class, which actually performs the work.
    public class Proxy : ISubject
    {
        private RealSubject realSubject;

        public void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            Console.WriteLine("Proxy: Logging the request.");
            realSubject.Request();
        }
    }
}
