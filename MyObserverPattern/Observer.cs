using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserverPattern
{
    class Observer : IObserver<ValueInfo>
    {
        private string name;
        private List<string> subscribers = new List<string>();
        private IDisposable cancellation;

        public Observer(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned a name.");

            this.name = name;
        }

        public virtual void Subscribe(Subject_Provider provider)
        {
            cancellation = provider.AttachObserver(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            subscribers.Clear();
        }

        public virtual void OnCompleted()
        {
            subscribers.Clear();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public virtual void OnError(Exception e)
        {
            // No implementation.
        }

        // Update information.
        public virtual void OnNext(ValueInfo info)
        {
            
                flightInfos.Sort();
                Console.WriteLine("Arrivals information from {0}", this.name);
                foreach (var flightInfo in flightInfos)
                    Console.WriteLine(flightInfo);

                Console.WriteLine();
            }
        }
    }
}
