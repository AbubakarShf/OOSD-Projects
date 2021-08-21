using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class SteakSupreme : Pizza
    {
        public SteakSupreme()
        {
            Name = "Steak Supreme";
            Ingredients.Add("Chicken");
            Ingredients.Add("Smooked Chicken");
            Ingredients.Add("Onion");
            Ingredients.Add("Green Peppers");
            Ingredients.Add("Olives");
            Ingredients.Add("Mashrooms");
        }
    }
}
