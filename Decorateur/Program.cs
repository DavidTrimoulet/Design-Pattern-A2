using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient maBoisson = new The(null);
            maBoisson = new Creme(maBoisson);
            maBoisson = new Sucre(maBoisson);

            Ingredient taBoisson = new Expresso(null);
            taBoisson = new Chocolat(taBoisson);
            taBoisson = new Creme(taBoisson);

            Ingredient trucChelou = new Chocolat(null);
            trucChelou = new Creme(trucChelou);
            trucChelou = new The(trucChelou);
            trucChelou = new Sucre(trucChelou);

            Console.WriteLine("Ma boisson coute : " + maBoisson.getPrixFinale().ToString());
            Console.WriteLine("Ta boisson coute : " + taBoisson.getPrixFinale().ToString());
            Console.WriteLine("Mon truc Chelou coute : " + maBoisson.getPrixFinale().ToString());
            Console.ReadLine();

        }
    }
}
