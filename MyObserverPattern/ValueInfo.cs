using System;
using System.Collections.Generic;
using System.Text;

namespace MyObserverPattern
{
    class ValueInfo
    {
        private int value;

        public ValueInfo(int value)
        {
            this.value = value;
        }

        public int GetValue
        {
            get
            {
                return this.value;
            }
        }
    }
}
