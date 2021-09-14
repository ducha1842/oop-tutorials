using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    class HaNoiPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HaNoiCheesePizza();
                case "greek":
                    return new HaNoiGreekPizza();
                case "pepperoni":
                    return new HaNoiPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
