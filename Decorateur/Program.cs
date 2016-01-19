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
            Ingredient maBoisson = new The();
            maBoisson = new Creme(maBoisson);
            maBoisson = new Sucre(maBoisson);

            Ingredient taBoisson = new Expresso();
            taBoisson = new Chocolat(taBoisson);
            taBoisson = new Creme(taBoisson);

            Console.WriteLine("Mon the coute : " + maBoisson.getPrix().ToString());
            Console.WriteLine("Ton café coute : " + taBoisson.getPrix().ToString());
            Console.ReadLine();

        }
    }
}
