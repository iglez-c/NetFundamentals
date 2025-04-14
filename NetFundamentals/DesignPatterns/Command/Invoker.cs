namespace NetFundamentals.DesignPatterns.Command
{
    // The Invoker class holds a reference to the ICommand object and calls its Execute() method.
    public class Invoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
