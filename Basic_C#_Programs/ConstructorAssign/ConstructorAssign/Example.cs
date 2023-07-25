using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssign
{
    public class Example
    {
        // Declaring two variables for use, without any values assigned
        public int x;
        public int y;

        // Here we are chaining two constructors so we can instantiate the object in two different ways, as well as not duplicating code unnecessarily 
        public Example(int x) : this(x, 2)
        {

        }

        public Example(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
