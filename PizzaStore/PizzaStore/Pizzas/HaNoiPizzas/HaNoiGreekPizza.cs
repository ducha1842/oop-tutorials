using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class HaNoiGreekPizza : Pizza
    {
        public HaNoiGreekPizza()
        {
            name = "HaNoi The good greek pizza";
            dough = "HaNoi Thin dough";
            sauce = "HaNoi Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }
    }
}
