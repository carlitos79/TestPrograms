using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceTest
{
    public class CartRepository : GenericRepository, ICartRepository
    {
        public void MethodE()
        {
            Console.WriteLine("Hello from Method E in CartRepository");
        }
    }
}
