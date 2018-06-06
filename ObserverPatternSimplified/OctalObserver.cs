using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternSimplified
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attachObserver(this);
        }

        public override void update()
        {
            Console.WriteLine("Octal string: " + Convert.ToString(subject.getState(), 8));
        }
    }
}
