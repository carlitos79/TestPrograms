using System;
using System.Collections.Generic;
using System.Text;

namespace TestProgram6
{
    public class A
    {
        public int value = 10;
    }

    public class B : A
    {
        public int GetValueFromParent()
        {
            return this.value;
        }
    }
}
