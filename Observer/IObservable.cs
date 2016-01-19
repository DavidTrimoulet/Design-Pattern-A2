using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppV1
{
    public interface IObservable
    {
        void enregistrerObservateur(IObservateur observateur);

        void supprimerObservateur(IObservateur observateur);

        void notifierObservateur();
    }
}
