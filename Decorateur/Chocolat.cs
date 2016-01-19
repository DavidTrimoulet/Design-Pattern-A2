using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Chocolat : IngredientBoisson
    {
        public Chocolat(Ingredient ingredientQueJeDecore) : base(ingredientQueJeDecore)
        {
            Description = "Chocolat";
            Prix = 0.15;
        }
    }
}
