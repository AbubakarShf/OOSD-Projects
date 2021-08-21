using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class SpecialOne:Pizza
    {
        public SpecialOne()
        {
            Name = "SpecialOne";
            Ingredients.Add("Chicken");
            Ingredients.Add("Onion");
            Ingredients.Add("Green Peppers");
            Ingredients.Add("Olives");
            Ingredients.Add("Mashrooms");
        }
    }
}
