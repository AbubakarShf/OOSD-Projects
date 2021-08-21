using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class ChickenTikka: Pizza
    {
        public ChickenTikka()
        {
            Name = "Chicken Tikka";
            Ingredients.Add("Chunks of Chicken");
            Ingredients.Add("Savory Onions");
        }
    }
}
