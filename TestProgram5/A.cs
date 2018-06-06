using System;
using System.Collections.Generic;
using System.Text;

namespace TestProgram5
{
    class A
    {
        public void CanFly()
        {
            Console.Write(" and fly ");
        }
    }

    class B : A
    {
        private string animal;

        public B(string animal)
        {
            this.animal = animal;
        }

        public void CanRun()
        {
            Console.Write(animal + " can run");
        }
    }
}
