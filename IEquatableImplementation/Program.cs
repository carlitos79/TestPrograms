using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Cesc");
            Person p2 = new Person("Cesc");

            if (p1.Equals(p2))
            {
                Console.WriteLine(p1.FirstName + " is the same as " + p2.FirstName);
            }
            else
            {
                Console.WriteLine(p1.FirstName + " is not the same as " + p2.FirstName);
            }

            Console.ReadKey();
        }
    }
}
