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
    public class Ribbons : TreeDecorator
    {
        public Ribbons(Tree t) : base(2,"Ribbons",t)
        {}
    }
}
