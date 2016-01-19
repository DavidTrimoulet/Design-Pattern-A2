using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    public abstract class Ingredient
    {
        public string Description { get; set; }
        public double Prix { get; set; }

        public abstract double getPrix();

    }
}
