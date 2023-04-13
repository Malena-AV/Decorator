using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Pizza
    {
        public string Name { get; set; }

        public Pizza(string name) 
        {
            this.Name = name;
        }

        public abstract int GetCost();
    }
}
