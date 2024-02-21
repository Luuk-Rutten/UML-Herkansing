using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{
    internal class Maaltijd
    {
        public int Tafelnummer {  get; set; }


        public int getTafelnummer(Bestelling b)
        {
            return Tafelnummer; 
        }

        public Maaltijd(int tafelnummer) 
        {
            //Tafelnummer = tafelnummer;
        }

    }
}
