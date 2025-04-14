using System;

namespace NetFundamentals.DesignPatterns.ChainOfResponsibility
{
    // The ConcreteHandler1 class handles requests that are less than 10.
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 10)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
