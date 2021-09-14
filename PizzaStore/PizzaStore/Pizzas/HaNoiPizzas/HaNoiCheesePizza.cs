using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HaNoiCheesePizza : Pizza
    {
        public HaNoiCheesePizza()
        {
            name = "HaNoi The best cheese pizza";
            dough = "HaNoi Very thin dough";
            sauce = "HaNoi Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }
    }
}
