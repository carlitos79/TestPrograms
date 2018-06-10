using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceTest
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            Games = new GameRepository();
            Carts = new CartRepository();
        }

        public IGameRepository Games { get; set; }
        public ICartRepository Carts { get; set; }
    }
}
