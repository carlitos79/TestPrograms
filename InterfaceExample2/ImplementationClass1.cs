using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class ImplementationClass1 : ISayHello
    {
        void ISayHello.SayHello()
        {
            Console.WriteLine("Hello from implementation class 1");
        }
    }
}
