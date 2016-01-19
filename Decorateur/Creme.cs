using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Creme : IngredientBoisson
    {
        public Creme(Ingredient ingredientQueJeDecore) : base(ingredientQueJeDecore)
        {
            Description = "Creme";
            Prix = 0.20;
        }
    }
}
