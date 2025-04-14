using System.Collections.Generic;

namespace NetFundamentals.DesignPatterns.Observer
{
    // This is the ConcreteSubject class
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int temperature;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public int GetTemperature()
        {
            return temperature;
        }

        public void SetTemperature(int temperature)
        {
            this.temperature = temperature;
            NotifyObservers();
        }
    }
}
