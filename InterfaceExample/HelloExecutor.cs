using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class HelloExecutor
    {
        public void SayHelloExecutor(params IHello[] objects)
        {
            foreach (var obj in objects)
            {
                obj.Hello();
            }
        }
    }
}
