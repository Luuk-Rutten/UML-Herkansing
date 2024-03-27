using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{
    public class Kok
    {
        public Balie Balie { get; set; }
     //  public  Bestelling Bestellingen { get; set; }

       // public  Maaltijd Maaltijden { get; set; }


         List<Maaltijd> Maaltijden = new List<Maaltijd>();

        List<Bestelling> Bestellingen = new List<Bestelling>();


        public Kok(Balie b)
        {
            Balie = b;
            CreateMedewerker();

        }

        public Maaltijd BereidMaaltijd(Bestelling b) 
        {

            Maaltijd maaltijd = new Maaltijd(b.Tafelnummer);

            return maaltijd;
          

        }
        public void BereidMaaltijden()
        {
            Bestelling bestelling;
            Maaltijd maaltijd;

            while (Balie.ErZijnNogBestellingen())
            {


                bestelling = Balie.PakBestelling();
                maaltijd = BereidMaaltijd(bestelling);

                Balie.PlaatsMaaltijd(maaltijd);

                maaltijd.getTafelnummer();

            }

        }

        public void CreateMedewerker()
        {
            Medewerker medewerker = new Medewerker();


        }


    }
}
