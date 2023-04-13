using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Паттерн используется для того, чтобы была возможность добавлять новые свойства объекту
    abstract class PizzaDecorator: Pizza
    {
        protected Pizza pizza;
        
        public PizzaDecorator(Pizza pizza, string name): base(name) 
        {
            this.pizza = pizza;
        }
    }
}
