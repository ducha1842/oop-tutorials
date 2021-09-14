using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class KhanhHoaCheesePizza : Pizza
    {
        public KhanhHoaCheesePizza()
        {
            name = "KhanhHoa The best cheese pizza";
            dough = "KhanhHoa Very thin dough";
            sauce = "KhanhHoa Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }
    }
}
