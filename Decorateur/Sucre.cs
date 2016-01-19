using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Sucre : IngredientBoisson
    {
        public Sucre(Ingredient ingredientQueJeDecore) : base(ingredientQueJeDecore)
        {
            Description = "Sucre";
            Prix = 0.05;
        }
    }
}
