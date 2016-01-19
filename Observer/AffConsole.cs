using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppV1
{
    class AffConsole : IObservateur
    {
        public int Temp { get; private set; }

        public int Humi { get; private set; }

        public int Press { get; private set; }

        public void afficher()
        {
            Console.WriteLine(String.Format("La temperature est de : {0}°C\nL'humidite est de {1}%\nLa pression est de {2} bar", Temp, Humi, Press));
        }

        public void actualiser(int temp, int humi, int press)
        {
            Temp = temp;
            Humi = humi;
            Press = press;
            afficher();
        }
    }
}
