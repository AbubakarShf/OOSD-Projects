using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class PizzaFactory
    {
        Pizza pizza;
        public Pizza CreatePizza(string name)
        {
            if (name.Equals("specialOne"))
                pizza = new SpecialOne();
            else if (name.Equals("CheeseSupreme"))
                pizza = new CheeseSupreme();
            else if (name.Equals("Chickentikka"))
                pizza = new ChickenTikka();
            else if (name.Equals("CheeseSupreme"))
                pizza = new CheeseSupreme();
            else if (name.Equals("chickenTandoori"))
                pizza = new ChickenTandoori();
            else if (name.Equals("beefFajita"))
                pizza = new BeefFajita();
            return pizza;
        }
    }
}
