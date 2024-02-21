using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{
    internal class Kok
    {
        public static Balie Balie { get; set; }

        Medewerker medewerker = new Medewerker();



       public void BereidMaaltijd(Bestelling b) 
        {
            //Bestelling bestelling = b;

            new Maaltijd(b.Tafelnummer);
           // Maaltijd.getTafelnummer();

        }
        public static void BereidMaaltijden()
        {
            while (Balie.ErZijnNogBestellingen())
            {
                Balie.PakBestelling();
            }

        }

        public Kok(Balie b)
        {
            Balie = b;
        }
    }
}
