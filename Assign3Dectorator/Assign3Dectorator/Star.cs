using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3Dectorator
{
    public class Star : TreeDecorator
    {
        public Star(Tree t) : base(4,"Star",t)
        {}
    }
}
