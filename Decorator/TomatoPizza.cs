﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza):base(pizza, pizza.Name + " с томатами") { }
        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}
