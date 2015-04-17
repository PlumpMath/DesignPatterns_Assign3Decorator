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
    public class Star
    {
        //this is an easy way to have the singleton pattern
        public static Lazy<Star> _Star = new Lazy<Star>(true);
        private const decimal starCost = 4;
        private const string _name = "Star";
        private Star()
        {}

        public static decimal Cost
        {
            get
            {
                return starCost;
            }
        }

        public static string Name
        {
            get { return _name; }
        }
    }
}
