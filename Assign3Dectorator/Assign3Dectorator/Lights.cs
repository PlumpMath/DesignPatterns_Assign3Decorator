using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3Dectorator
{
    public class Lights : TreeDecorator
    {
        public Lights(Tree t) : base(5,"Lights",t)
        {}
    }
}
