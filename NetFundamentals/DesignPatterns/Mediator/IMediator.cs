namespace NetFundamentals.DesignPatterns.Mediator
{
    // The Mediator interface defines the methods that a mediator must implement.
    public interface IMediator
    {
        void Notify(object sender, string message);
    }
}
