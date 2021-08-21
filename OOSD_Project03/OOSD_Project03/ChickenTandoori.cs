using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class ChickenTandoori:Pizza
    {
        public ChickenTandoori()
        {
            Name = "Chicken Tandoori";
            Ingredients.Add("Tandoori Sauce");
            Ingredients.Add("Onions");
            Ingredients.Add("Chicken");
        }
    }
}
