using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    class KhanhHoaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new KhanhHoaCheesePizza();
                case "greek":
                    return new KhanhHoaGreekPizza();
                case "pepperoni":
                    return new KhanhHoaPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
