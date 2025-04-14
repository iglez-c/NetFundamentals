using System;

namespace NetFundamentals.DesignPatterns.Mediator
{
    // The ConcreteColleague2 class implements the IColleague interface and communicates with other colleagues through the mediator.
    public class ConcreteColleague2 : IColleague
    {
        private IMediator mediator;

        public ConcreteColleague2(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Send(string message)
        {
            mediator.Notify(this, message);
        }

        public void Receive(string message)
        {
            Console.WriteLine("ConcreteColleague2 received: " + message);
        }
    }
}
