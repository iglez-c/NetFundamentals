namespace NetFundamentals.DesignPatterns.Observer
{
    // This is the Subject interface
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
