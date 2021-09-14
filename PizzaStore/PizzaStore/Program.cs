using PizzaStore.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var haNoipizzaStore = new HaNoiPizzaStore();
            haNoipizzaStore.OrderPizza("cheese");
            var khanhHoapizzaStore = new KhanhHoaPizzaStore();
            khanhHoapizzaStore.OrderPizza("cheese");
            var saiGonpizzaStore = new SaiGonPizzaStore();
            saiGonpizzaStore.OrderPizza("cheese");

            Console.ReadKey();
        }
    }
}
