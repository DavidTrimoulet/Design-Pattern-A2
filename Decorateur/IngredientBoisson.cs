using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class IngredientBoisson : Ingredient
    {
        public Ingredient IngredientDecore { get; set; }

        public IngredientBoisson(Ingredient ingredientAuquelJemAjoute)
        {
            IngredientDecore = ingredientAuquelJemAjoute;
        }

        public override double getPrixFinale()
        {
            if(IngredientDecore == null)
            {
                return Prix;
            }
            else
            {
                return Prix + IngredientDecore.getPrixFinale();

            }
        }
    }
}
