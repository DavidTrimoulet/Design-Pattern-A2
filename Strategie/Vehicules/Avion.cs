using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategie
{
    class Avion : Vehicule
    {
        public Avion()
        {
            ModeDeDeplacement = new Voler();
        }
    }
}
