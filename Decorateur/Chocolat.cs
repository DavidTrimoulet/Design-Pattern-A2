using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Chocolat : IngredientSup
    {
        public Chocolat(Ingredient boisson) : base(boisson)
        {
            Prix = 0.15;
        }
    }
}
