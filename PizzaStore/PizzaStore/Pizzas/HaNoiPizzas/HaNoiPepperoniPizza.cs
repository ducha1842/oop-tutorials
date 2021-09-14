using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HaNoiPepperoniPizza : Pizza
    {
        public HaNoiPepperoniPizza()
        {
            name = "HaNoi The best Pepperoni";
            dough = "HaNoi Very thick dough";
            sauce = "HaNoi Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
