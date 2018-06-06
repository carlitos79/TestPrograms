using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample
{
    public class TemperatureSubject : IObserver<Temperature>
    {
        private IDisposable attachObserver;
        private bool first = true;
        private Temperature last;

        public virtual void Subscribe(IObservable<Temperature> subject)
        {
            attachObserver = subject.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            attachObserver.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Additional temperature data will not be transmitted.");
        }

        public virtual void OnError(Exception error)
        {
            // Do nothing.
        }

        public virtual void OnNext(Temperature value)
        {
            Console.WriteLine("The temperature is {0}°C at {1:g}", value.Degrees, value.Date);

            if (first)
            {
                last = value;
                first = false;
            }
            else
            {
                Console.WriteLine("   Change: {0}° in {1:g}", value.Degrees - last.Degrees,
                                                              value.Date.ToUniversalTime() - last.Date.ToUniversalTime());
            }
        }
    }
}
