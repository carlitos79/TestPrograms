using System;

namespace ObserverPatternSimplified
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attachObserver(this);
        }

        public override void update()
        {
            Console.WriteLine("Hexa string: " + subject.getState().ToString("X"));
        }
    }
}
