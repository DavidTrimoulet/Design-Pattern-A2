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
            Console.WriteLine("La temperature est de :" + Temp + "\n L'humidite est de " + Humi + "\n La pression est de " + Press) ;
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
