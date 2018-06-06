using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person("Pedro");
            //Person p2 = new Person("Pedro");

            //Console.WriteLine(p1.Equals(p2));

            ChildClass c = new ChildClass();
            int n = c.GetNumFromParent();
            c.SayHello();
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
