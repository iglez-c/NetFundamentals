namespace NetFundamentals.DesignPatterns.Mediator
{
    // The Colleague interface defines the methods that a colleague must implement.
    public interface IColleague
    {
        void Send(string message);
        void Receive(string message);
    }
}
