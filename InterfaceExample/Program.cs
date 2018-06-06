using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                HelloExecutor exe = new HelloExecutor();

                IHello imp1 = new HelloImplementator1();
                IHello imp2 = new HelloImplementator2();

                exe.SayHelloExecutor(imp1, imp2);
            }
        }
    }
}
