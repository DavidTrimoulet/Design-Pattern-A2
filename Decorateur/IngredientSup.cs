using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class IngredientSup : Ingredient
    {
        public Ingredient BoissonDecore { get; set; }
        public IngredientSup(Ingredient boisson)
        {
            BoissonDecore = boisson;
        }

        public override double getPrix()
        {
            return Prix + BoissonDecore.getPrix();
        }
    }
}
