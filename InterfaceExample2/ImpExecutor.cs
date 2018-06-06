using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class ImpExecutor
    {
        public void ExecuteImp(params ISayHello[] objects)
        {
            foreach (var obj in objects)
            {
                obj.SayHello();
            }
        }
    }
}
