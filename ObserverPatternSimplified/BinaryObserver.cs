using System;

namespace ObserverPatternSimplified
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attachObserver(this);
        }

        public override void update()
        {
            Console.WriteLine("Binary string: " + Convert.ToString(subject.getState(), 2));
        }
    }
}
