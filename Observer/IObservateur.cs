using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppV1
{
    public interface IObservateur
    {
        void actualiser(int temp, int humi, int press);
    }
}
