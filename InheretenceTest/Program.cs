using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork uow = new UnitOfWork();

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Print(uow);
            }
        }

        public static void Print(params UnitOfWork[] objs)
        {
            foreach (var obj in objs)
            {
                obj.Games.MethodA();
                obj.Games.MethodB();
                obj.Games.MethodC();
                obj.Games.MethodD();
                obj.Carts.MethodE();
            }
        }
    }
}
