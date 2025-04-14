using System;

namespace NetFundamentals.DesignPatterns.Command
{
    // The Receiver class defines the object that the commands will act upon.
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Receiver.Action() executed");
        }
    }
}
