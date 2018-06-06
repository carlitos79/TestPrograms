using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternTest
{
    public interface EnemyState
    {
        void Chase();
        void Engage();
        void Evade();
    }
}
