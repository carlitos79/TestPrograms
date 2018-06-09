using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementorInterface2 obj = new ImplementorInterface2();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Print(obj);
            }           
        }

        public static void Print(params ImplementorInterface2[] objs)
        {
            foreach (var obj in objs)
            {
                obj.classA();
                obj.classB();
                obj.classC();
                obj.ClassD();
            }
        }
    }
}
