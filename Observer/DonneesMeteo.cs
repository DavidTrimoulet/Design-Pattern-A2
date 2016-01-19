using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppV1
{
    class DonneesMeteo : IObservable
    {
        public int Temp { get; set; }
        public int Humidite { get; set; }
        public int Pression { get; set; }
        public List<IObservateur> MesObs { get; private set; }

        public DonneesMeteo()
        {
            MesObs = new List<IObservateur>();
        }

        public int getTemperature()
        {
            return (new Random()).Next(30);
        }
        public int getHumidite()
        {
            return (new Random()).Next(90);
        }
        public int getPression()
        {
            return (new Random()).Next(1000);
        }

        public void actualiserMesures()
        {
            Temp = getTemperature();
            Humidite = getHumidite();
            Pression = getPression();
            notifierObservateur();
        }

        public void enregistrerObservateur(IObservateur observateur)
        {
            MesObs.Add(observateur);
        }

        public void supprimerObservateur(IObservateur observateur)
        {
            MesObs.Remove(observateur);
        }

        public void notifierObservateur()
        {
            foreach(IObservateur obs in MesObs)
            {
                obs.actualiser(Temp, Humidite, Pression);
            }
        }
    }
}
