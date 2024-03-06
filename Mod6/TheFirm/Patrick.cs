using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Patrick : Werknemer
    {
        public void DoetIets()
        {
            System.Console.WriteLine("Patrick geeft les");
        }

        public override void Werkt()
        {
            DoetIets();
        }
    }
}