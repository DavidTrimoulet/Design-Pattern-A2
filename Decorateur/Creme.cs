using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Creme : IngredientSup
    {
        public Creme(Ingredient boisson) : base(boisson){
            Prix = 0.20;
        }
    }
}
