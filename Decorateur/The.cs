using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class The : IngredientBoisson
    {
        public The(Ingredient ingredientQueJeDecore) : base(ingredientQueJeDecore)
        {
            this.Description = "The";
            this.Prix = 0.20;
        }
    }
}
