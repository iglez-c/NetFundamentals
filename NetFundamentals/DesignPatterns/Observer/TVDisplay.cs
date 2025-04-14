using System;

namespace NetFundamentals.DesignPatterns.Observer
{
    // This is another ConcreteObserver class
    public class TVDisplay : IObserver
    {
        private WeatherStation weatherStation;

        public TVDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void Update()
        {
            int temperature = weatherStation.GetTemperature();
            Console.WriteLine("TV Display: The temperature is " + temperature + " degrees.");
        }
    }
}
