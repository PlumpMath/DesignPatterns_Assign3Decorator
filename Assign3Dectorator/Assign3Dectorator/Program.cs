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
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new DouglasFir();
            t.HasStar = true;
            t = new Ribbons(t);
            t = new Lights(t);
            t = new Ribbons(t);
            t.HasStar = true;
            t = new BallsRed(t);

            Console.WriteLine(t.PrintTree());

            Tree s = new ColoradoBlueSpruce();
            s = new Lights(s);
            //s.HasStar = true;
            s = new BallsSilver(s);

            Console.WriteLine(s.PrintTree());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
