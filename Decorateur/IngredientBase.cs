using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class IngredientBase : Ingredient
    {
        public override double getPrix()
        {
            return Prix;
        }
    }
}
