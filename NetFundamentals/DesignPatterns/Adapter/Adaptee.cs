using System;

namespace NetFundamentals.DesignPatterns.Adapter
{
    // The Adaptee is the class that needs to be adapted to the Target interface.
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's specific request.");
        }
    }
}
