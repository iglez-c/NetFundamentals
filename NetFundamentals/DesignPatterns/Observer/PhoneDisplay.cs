using System;

namespace NetFundamentals.DesignPatterns.Observer
{
    // This is the ConcreteObserver class
    class PhoneDisplay : IObserver
    {
        private WeatherStation weatherStation;

        public PhoneDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void Update()
        {
            int temperature = weatherStation.GetTemperature();
            Console.WriteLine("Phone Display: The temperature is " + temperature + " degrees.");
        }
    }
}
