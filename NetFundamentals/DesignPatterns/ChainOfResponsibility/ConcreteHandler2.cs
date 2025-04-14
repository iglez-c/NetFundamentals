using System;

namespace NetFundamentals.DesignPatterns.ChainOfResponsibility
{
    // The ConcreteHandler2 class handles requests that are greater than or equal to 10 but less than 20.
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
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
