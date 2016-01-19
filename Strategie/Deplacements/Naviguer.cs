using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategie
{
    class Naviguer : IDeplacement
    {
        public void seDeplacer()
        {
            Console.WriteLine("Je navigue");
        }
    }
}
