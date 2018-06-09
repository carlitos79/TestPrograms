using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceTest
{
    public class GenericRepository : IGenericRepository
    {
        public void MethodA()
        {
            Console.WriteLine("Hello from Method A in GenericRepository");
        }

        public void MethodB()
        {
            Console.WriteLine("Hello from Method B in GenericRepository");
        }

        public void MethodC()
        {
            Console.WriteLine("Hello from Method C in GenericRepository");
        }
    }
}
