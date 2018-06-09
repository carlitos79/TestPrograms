using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceTest
{
    public class GameRepository : GenericRepository, IGameRepository
    {
        public void MethodD()
        {
            Console.WriteLine("Hello from Method D in GameRepository");
        }
    }
}
