using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWe use FactoryMethode in it\n");
            PizzaFactory pizzaFactory = new PizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(pizzaFactory);
            Pizza pizzaNS = pizzaStore.OrderPizza("CheeseSupreme");
            Pizza pizzaCT = pizzaStore.OrderPizza("Chickentikka");
            Console.ReadKey();
        }
    }
}
