using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3Dectorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new DouglasFir();
            t = new Star(t);
            t = new Star(t);
            t = new Ribbons(t);
            t = new Lights(t);
            t = new Ribbons(t);

            //Console.WriteLine("Cost:{0}", t.Cost);
            Console.WriteLine(t.PrintTree());
            Console.ReadKey();
        }
    }
}
