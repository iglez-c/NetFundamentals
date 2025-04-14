using System;

namespace NetFundamentals.DesignPatterns.ChainOfResponsibility
{
    // The ConcreteHandler3 class handles requests that are greater than or equal to 20.
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20)
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
