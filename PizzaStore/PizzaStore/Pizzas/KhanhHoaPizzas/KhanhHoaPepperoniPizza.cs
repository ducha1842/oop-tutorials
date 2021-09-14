using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class KhanhHoaPepperoniPizza : Pizza
    {
        public KhanhHoaPepperoniPizza()
        {
            name = "KhanhHoa The best Pepperoni";
            dough = "KhanhHoa Very thick dough";
            sauce = "KhanhHoa Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
