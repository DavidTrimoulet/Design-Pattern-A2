using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategie
{
    class Voler : IDeplacement
    {
        public void seDeplacer()
        {
            Console.WriteLine("Je Vole");
        }
    }
}
