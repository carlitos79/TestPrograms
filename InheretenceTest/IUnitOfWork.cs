﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretenceTest
{
    public interface IUnitOfWork
    {
        IGameRepository Games { get; set; }
        ICartRepository Carts { get; set; }
    }
}
