﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BulgarianPizza : Pizza
    {
        public BulgarianPizza():base("Болгарская пицца") { }
        public override int GetCost()
        {
           return 8;
        }
    }
}
