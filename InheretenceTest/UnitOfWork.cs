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
        }

        public IGameRepository Games { get; set; }
    }
}
