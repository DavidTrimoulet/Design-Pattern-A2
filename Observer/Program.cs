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
            DonneesMeteo _maStation = new DonneesMeteo();
            Window1 _monAffFenetre = new Window1();
            AffConsole _monAffConsole = new AffConsole();
            _maStation.enregistrerObservateur(_monAffFenetre);
            _maStation.enregistrerObservateur(_monAffConsole);
            _monAffFenetre.Show();

            while (true)
            {
                _maStation.actualiserMesures();
            }
        }
    }
}
