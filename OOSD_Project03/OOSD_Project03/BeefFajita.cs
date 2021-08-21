using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_Project03
{
    class BeefFajita : Pizza
    {
        public BeefFajita()
        {
            Name = "Beef Fajita";
            Ingredients.Add("Maxican Feast of Marinated Grilled Beef");
            Ingredients.Add("Onions");
            Ingredients.Add("Green Peppers");
        }
    }
}