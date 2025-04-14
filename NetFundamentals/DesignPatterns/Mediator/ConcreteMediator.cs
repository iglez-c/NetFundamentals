namespace NetFundamentals.DesignPatterns.Mediator
{
    // The ConcreteMediator class implements the IMediator interface and mediates communication between colleagues.
    public class ConcreteMediator : IMediator
    {
        private ConcreteColleague1 colleague1;
        private ConcreteColleague2 colleague2;

        public ConcreteColleague1 Colleague1
        {
            set { colleague1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { colleague2 = value; }
        }

        public void Notify(object sender, string message)
        {
            if (sender == colleague1)
            {
                colleague2.Receive(message);
            }
            else if (sender == colleague2)
            {
                colleague1.Receive(message);
            }
        }
    }
}
