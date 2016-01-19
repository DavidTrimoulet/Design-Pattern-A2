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
            Ingredient _maBoisson = new The();
            _maBoisson = new Creme(_maBoisson);
            _maBoisson = new Sucre(_maBoisson);

            Ingredient _taBoisson = new Expresso();
            _taBoisson = new Chocolat(_taBoisson);
            _taBoisson = new Creme(_taBoisson);

            Console.WriteLine("Mon the coute : " + _maBoisson.getPrix().ToString());
            Console.WriteLine("Ton café coute : " + _taBoisson.getPrix().ToString());
            Console.ReadLine();


        }
    }
}
