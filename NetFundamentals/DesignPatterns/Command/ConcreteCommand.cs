namespace NetFundamentals.DesignPatterns.Command
{
    // The ConcreteCommand class implements the ICommand interface and holds a reference to the Receiver object.
    public class ConcreteCommand : ICommand
    {
        private Receiver receiver;

        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action();
        }
    }
}
