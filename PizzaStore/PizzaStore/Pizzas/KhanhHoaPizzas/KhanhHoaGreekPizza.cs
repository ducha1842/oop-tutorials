using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class KhanhHoaGreekPizza : Pizza
    {
        public KhanhHoaGreekPizza()
        {
            name = "KhanhHoa The good greek pizza";
            dough = "KhanhHoa Thin dough";
            sauce = "KhanhHoa Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }
    }
}
