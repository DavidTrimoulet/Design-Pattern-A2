using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton moiMeme;

        private Singleton()
        {
            // Constructeur privé
        }

        public static Singleton getInstance()
        {
            if (moiMeme == null)
            {
                moiMeme = new Singleton();
            }
            return moiMeme;
        }

    }
}
