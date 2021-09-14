using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    class SaiGonPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new SaiGonCheesePizza();
                case "greek":
                    return new SaiGonGreekPizza();
                case "pepperoni":
                    return new SaiGonPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
