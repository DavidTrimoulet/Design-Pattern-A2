using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppV1
{
    class Program
    {
        static void Main(string[] args)
        {
            DonneesMeteo maStation = new DonneesMeteo();
            Window1 monAffFenetre = new Window1();
            AffConsole monAffConsole = new AffConsole();
            maStation.enregistrerObservateur(monAffFenetre);
            maStation.enregistrerObservateur(monAffConsole);
            monAffFenetre.Show();

            while (true)
            {
                maStation.actualiserMesures();
                Thread.Sleep(1000);
            }
        }
    }
}
