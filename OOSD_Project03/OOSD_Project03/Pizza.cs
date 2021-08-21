using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    abstract class Pizza
    {
        public string Name;
        public List<string> Ingredients = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Pizza :\t{0}", Name);
            Console.WriteLine("Toppings:\n----------");
            foreach (string s in Ingredients)
            {
                Console.WriteLine(s);
            }
        }
    }
}
