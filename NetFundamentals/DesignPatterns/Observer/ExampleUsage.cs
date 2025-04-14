using System;

namespace NetFundamentals.DesignPatterns.Observer
{
    /// <summary>
    /// In this example, we have a WeatherStation class that implements the ISubject interface.
    /// The WeatherStation has a list of IObserver objects, which it notifies whenever its temperature changes.
    /// The PhoneDisplay and TVDisplay classes are concrete observers that implement the IObserver interface.
    /// They register themselves with the WeatherStation and get notified whenever the temperature changes.
    /// Finally, in the Main method, we create a WeatherStation object, create two observers (PhoneDisplay and TVDisplay),
    /// register them with the WeatherStation, and then change the temperature of the WeatherStation.
    /// </summary>
    public class ExampleUsage
    {
        // This is the client code
        public void Execute()
        {
            Console.WriteLine("--==== Observer ====--");
            WeatherStation weatherStation = new WeatherStation();
            PhoneDisplay phoneDisplay = new PhoneDisplay(weatherStation);
            TVDisplay tvDisplay = new TVDisplay(weatherStation);
            weatherStation.RegisterObserver(phoneDisplay);
            weatherStation.RegisterObserver(tvDisplay);
            weatherStation.SetTemperature(20);
            weatherStation.RemoveObserver(tvDisplay);
            weatherStation.SetTemperature(25);
        }
    }
}
