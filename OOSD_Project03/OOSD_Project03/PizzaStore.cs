using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class PizzaStore
    {
        PizzaFactory pizzaFactory;
        public PizzaStore(PizzaFactory factory)
        {
            pizzaFactory = factory;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = pizzaFactory.CreatePizza(type);
            pizza.Prepare();
            return pizza;
        }
    }
}
