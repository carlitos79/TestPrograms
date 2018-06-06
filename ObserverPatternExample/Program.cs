using System;

namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureSubject provider = new TemperatureSubject();

            TemperatureObserver observer1 = new TemperatureObserver();
            TemperatureObserver observer2 = new TemperatureObserver();

            provider.Subscribe(observer1);
            observer1.GetTemperature();

            provider.Subscribe(observer2);
            observer2.GetTemperature();
        }
    }
}
