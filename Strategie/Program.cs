using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicule> _mesVehicules = new List<Vehicule>();
            _mesVehicules.Add(new Avion());
            _mesVehicules.Add(new Voiture());
            _mesVehicules.Add(new Bateau());

            foreach(Vehicule v in _mesVehicules)
            {
                Console.WriteLine(v.GetType().ToString());
                v.ModeDeDeplacement.seDeplacer();
            }
            Console.ReadLine();

        }
    }
}
