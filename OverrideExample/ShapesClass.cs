using System;
using System.Collections.Generic;
using System.Text;

namespace OverrideExample
{
    abstract class ShapesClass
    {
        abstract public int Area();
    }

    class Square : ShapesClass
    {
        int side = 0;

        public Square(int side)
        {
            this.side = side;
        }

        public override int Area()
        {
            return side * side;
        }
    }
}
