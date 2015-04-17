using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * James Felts
 */

namespace Assign3Dectorator
{
    public class Lights : TreeDecorator
    {
        public Lights(Tree t) : base(5,"Lights",t)
        {}
    }
}
