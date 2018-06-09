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
                uow.Games.MethodA();
                uow.Games.MethodB();
                uow.Games.MethodC();
                uow.Games.MethodD();
            }
        }
    }
}
