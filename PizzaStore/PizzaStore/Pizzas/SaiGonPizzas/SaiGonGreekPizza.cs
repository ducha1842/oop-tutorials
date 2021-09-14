using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class SaiGonGreekPizza : Pizza
    {
        public SaiGonGreekPizza()
        {
            name = "The good greek pizza";
            dough = "Thin dough";
            sauce = "Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }
    }
}
