using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class CheeseSupreme:Pizza
    {
        public CheeseSupreme()
        {
            Name = "Cheese Supreme";
            Ingredients.Add("Spicy Chicken");
            Ingredients.Add("Chicken");
            Ingredients.Add("Cheese");
            Ingredients.Add("Smoked Chicken");
            Ingredients.Add("Onion");
            Ingredients.Add("Green Peppers");
            Ingredients.Add("Olives");
            Ingredients.Add("Mashrooms");
        }
    }
}
