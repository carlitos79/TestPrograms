﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternSimplified
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void update();
    }
}