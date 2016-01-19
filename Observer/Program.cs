using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppV1
{
    class Program
    {
        private static DonneesMeteo _maStation;
        private static Window1 _monAffFenetre;
        private static AffConsole _monAffConsole;

        static void Main(string[] args)
        {
            _maStation = new DonneesMeteo();
            _monAffFenetre = new Window1();
            _monAffConsole = new AffConsole();
            _maStation.enregistrerObservateur(_monAffFenetre);
            _maStation.enregistrerObservateur(_monAffConsole);

            // Lancement du programme
            new Thread(Program.Job).Start();
            Application.EnableVisualStyles();
            Application.Run(_monAffFenetre);

        }

        public static void Job()
        {
            while (true)
            {
                _maStation.actualiserMesures();
                Thread.Sleep(250);
            }
        }


    }
}
