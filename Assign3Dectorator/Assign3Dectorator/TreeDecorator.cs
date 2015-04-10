using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3Dectorator
{
    public abstract class TreeDecorator : Tree
    {
        public TreeDecorator()
        {}

        public TreeDecorator(decimal cost, string name, Tree t) : base(cost,name,t)
        {}

        public override decimal Cost
        {
            get
            {
                return Decorator.Cost + base.Cost;
            }
        }
    }
}
