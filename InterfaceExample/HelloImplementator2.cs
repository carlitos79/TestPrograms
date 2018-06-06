using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class HelloImplementator2 : IHello
    {
        void IHello.Hello()
        {
            Console.WriteLine("Hello from implementator 2");
        }
    }
}
