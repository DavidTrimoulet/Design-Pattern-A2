using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique
{
    //La fabrique de troupe
    class Caserne : BatimentDeProduction
    {
                
        public Unite produireUnite(string demande)
        {
            Unite formedUnit = null;
            if (demande.Equals("Marine"))
            {
                formedUnit = new Marine();
            }
            else if (demande.Equals("Maraudeur"))
            {
                formedUnit = new Maraudeur();
            }
            else if (demande.Equals("Faucheur"))
            {
                formedUnit = new Faucheur();
            }
            else if (demande.Equals("Ghost"))
            {
                formedUnit = new Ghost();
            }

            return formedUnit;
        }
    }
}
