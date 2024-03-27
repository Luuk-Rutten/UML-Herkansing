using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{
    public class Maaltijd
    {
        public int Tafelnummer {  get; set; }


        public int getTafelnummer()
        {
            return Tafelnummer; 
        }

        public Maaltijd(int tafelnummer) 
        {
            //Tafelnummer = tafelnummer;
        }

    }
}
