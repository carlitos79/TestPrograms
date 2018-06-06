using System;

namespace InterfaceExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISayHello ex1 = new ImplementationClass1();
            ISayHello ex2 = new ImplementationClass2();

            //ex1.SayHello();
            //ex2.SayHello();

            ImpExecutor exe = new ImpExecutor();

            exe.ExecuteImp(ex1, ex2);

            Console.ReadKey();
        }
    }
}
