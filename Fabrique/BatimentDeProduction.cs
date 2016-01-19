using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique
{
    interface BatimentDeProduction
    {
        Unite produireUnite(string demande);
    }
}
