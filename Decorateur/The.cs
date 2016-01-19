using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class The : IngredientBase
    {
        public The()
        {
            this.Description = "The";
            this.Prix = 0.20;
        }
    }
}
