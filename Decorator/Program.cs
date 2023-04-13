using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new ItalianPizza();
            Console.WriteLine(pizza.Name + ": " + pizza.GetCost());

            pizza = new CheesePizza(pizza);
            Console.WriteLine(pizza.Name + ": " + pizza.GetCost());

            pizza = new TomatoPizza(pizza);
            Console.WriteLine(pizza.Name + ": " + pizza.GetCost());

            Console.ReadLine();
        }
    }
}
