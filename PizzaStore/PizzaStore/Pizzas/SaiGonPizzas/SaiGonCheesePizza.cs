using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class SaiGonCheesePizza : Pizza
    {
        public SaiGonCheesePizza()
        {
            name = "SaiGon The best cheese pizza";
            dough = "SaiGon Very thin dough";
            sauce = "SaiGon Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }
    }
}
