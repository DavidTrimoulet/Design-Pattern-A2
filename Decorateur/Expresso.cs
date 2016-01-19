using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Expresso : IngredientBase
    {
        public Expresso()
        {
            this.Description = "Expresso";
            this.Prix = 0.40;
        }

        
    }
}
