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
    delegate T SelfApplicable<T>(SelfApplicable<T> self, T list, Tree t);
    public abstract class Tree
    {
        private decimal _cost;
        private string _name;
        private Tree _decorator;
        private bool _hasStar;
        
        public Tree()
        {}

        public Tree(decimal cost, string name)
        {
            _cost = cost;
            _name = name;
        }

        public Tree(decimal cost, string name, Tree t) : this(cost,name)
        {
            _decorator = t;
            if(t.HasStar == false)
            {
                HasStar = false;
            }
            else
            {
                HasStar = true;
            }
            
        }

        public virtual decimal Cost
        {
            get 
            {
                decimal temp = 0;
                temp = this._cost;
                Tree t;
                t = _decorator;
                
                //loop through the decorators since this way it is easier to add the cost of the Star
                //then it is with recursion
                while(t != null)
                {
                    temp += t._cost;
                    t = t._decorator;
                }
                
                if(_hasStar)
                {
                    temp += Star.Cost;
                }


                return temp;
            }
        }

        public Tree Decorator
        {
            get
            {
                return _decorator;
            }
        }

        public string Name
        {
            get { return _name; }
        }

        public string PrintTree()
        {
            StringBuilder s = new StringBuilder();
            List<string> str = new List<string>();

            //rescursive lambdas for fun and profit
            //gets a list of decorators starting with the tree and building the list up from there
            SelfApplicable<List<string>> printHelper = (fun, y, t) =>
            {
                if(t._decorator == null)
                {
                    y.Add(t._name);
                }
                else
                {
                    fun(fun, y, t._decorator);
                    y.Add(t._name);
                }
                return y;
            };

            str = printHelper(printHelper,str,this);

            s.Append(str[0]);
            s.Append(" tree decorated with ");
            //to handle if the tree has a star
            if(_hasStar)
            {
                s.Append(Star.Name);
                
            }


            for (int i = 1; i < str.Count;i++ )
            {
                s.Append(", "+str[i]);
            }
            s.Append(" costs $");
            s.Append(this.Cost);
            

            return s.ToString();

        }

        public bool HasStar
        {
            set 
            {
                if (_hasStar==false)
                {
                    _hasStar = value;
                }
                else
                {
                    Console.WriteLine("Tree already has a star!");
                }
                
            }
            get { return _hasStar; }
        }

    }
}
