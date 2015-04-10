using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3Dectorator
{
    public abstract class Tree
    {
        private decimal _cost;
        private string _name;
        private Tree _decorator;
        private static Lazy<Star> _star;

        public Tree()
        {}

        public Tree(decimal cost, string name)
        {
            _cost = cost;
            _name = name; 
        }

        public Tree(decimal cost, string name, Tree t)
        {
            _cost = cost;
            _name = name;
            if(this is Star)
            {
                if(_star!=null)
                {
                    Console.WriteLine("Tree already has a Star!");
                    _decorator = t.Decorator;
                }
                else
                {
                    _star = new Lazy<Star>();
                    _decorator = t;
                }
            }
            else
            {
                _decorator = t;
            }
            
        }

        public virtual decimal Cost
        {
            get 
            { 
                return _cost; 
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
            str = PrintTreeHelper(str);
            s.Append(str[0]);
            s.Append(" tree decorated with");
            for (int i = 1; i < str.Count;i++ )
            {
                s.Append(", "+str[i]);
            }
            s.Append(" costs $");
            s.Append(this.Cost);
            

            return s.ToString();

        }

        private List<string> PrintTreeHelper(List<string> s)
        {
            if(_decorator == null)
            {
                s.Add(_name);
                return s;
            }
            s = _decorator.PrintTreeHelper(s);
            s.Add(_name);
            return s;
        }

    }
}
