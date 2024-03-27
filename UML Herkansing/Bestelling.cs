using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{
    public class Bestelling 
    {
        public int Bestelnummer { get; set; }
        public int Tafelnummer { get; set; }

        public Bestelling(int bestelnr, int tafelnr) 
        {
           Bestelnummer = bestelnr;
            Tafelnummer = tafelnr;
        }

    }
}
