using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Sucre : IngredientSup
    {
        public Sucre(Ingredient boisson) : base(boisson)
        {
            Prix = 0.05;
        }
    }
}
