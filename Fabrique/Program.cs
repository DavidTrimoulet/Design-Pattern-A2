using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrique
{
    class Program
    {
        static void Main(string[] args)
        {

            Caserne maCaserne = new Caserne();
            List<Unite> monArmee = new List<Unite>();
            monArmee.Add(maCaserne.produireUnite("Marine"));
            monArmee.Add(maCaserne.produireUnite("Maraudeur"));
            monArmee.Add(maCaserne.produireUnite("Ghost"));
            monArmee.Add(maCaserne.produireUnite("Faucheur"));


            foreach(Unite u in monArmee)
            {
                Console.WriteLine("je suis un " + u.GetType().ToString() + ", je coute :  " + u.Cout.ToString() + ", je fais " + u.Degats + " degats et j'ai " + u.Armure + " point d'armure.");
            }
            Console.ReadLine();
        }
    }
}
