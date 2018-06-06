using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserverPattern
{
    class Subject_Provider
    {
        private List<IObserver<ValueInfo>> observers;
        private List<ValueInfo> valuesToUpdate;

        public Subject_Provider()
        {
            observers = new List<IObserver<ValueInfo>>();
            valuesToUpdate = new List<ValueInfo>();
        }

        public IDisposable AttachObserver(IObserver<ValueInfo> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                
                foreach (var item in valuesToUpdate)
                    observer.OnNext(item);
            }
            return new Unsubscriber<ValueInfo>(observers, observer);
        }

        public void NotifyObservers(int x)
        {
            var info = new ValueInfo(x);

            valuesToUpdate.Add(info);

            foreach (var observer in observers)
            {
                observer.OnNext(info);
            }
        }

        public void LastObserverInformed()
        {
            foreach (var observer in observers)
                observer.OnCompleted();

            observers.Clear();
        }

        internal class Unsubscriber<BaggageInfo> : IDisposable
        {
            private List<IObserver<BaggageInfo>> _observers;
            private IObserver<BaggageInfo> _observer;

            internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
