using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFirm
{
    public abstract class Werknemer : Persoon, IContract
    {
        public void VoerUit()
        {
          Werkt();
        }

        public abstract void Werkt();
    }
}