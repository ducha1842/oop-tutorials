using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class SaiGonPepperoniPizza : Pizza
    {
        public SaiGonPepperoniPizza()
        {
            name = "The best Pepperoni";
            dough = "Very thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
