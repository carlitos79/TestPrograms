using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    public class ImplementorInterface1 : Interface1
    {
        public void classA()
        {
            Console.WriteLine("Class A");
        }

        public void classB()
        {
            Console.WriteLine("Class B");
        }

        public void classC()
        {
            Console.WriteLine("Class C");
        }
    }
}
