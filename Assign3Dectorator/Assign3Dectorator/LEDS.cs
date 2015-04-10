using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3Dectorator
{
    public class LEDS : TreeDecorator
    {
        public LEDS(Tree t) : base(10,"LEDS",t)
        {}
    }
}
