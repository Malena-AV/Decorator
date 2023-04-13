using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza):base (pizza, pizza.Name + " с сыром") { }
        public override int GetCost()
        {
            return pizza.GetCost() + 2;
        }
    }
}
