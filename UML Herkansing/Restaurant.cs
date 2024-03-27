using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{


    public class Restaurant
    {
        public int AANTALTAFELS = 10;
        public int AANTALBESTELLINGEN = 20;
 

        public Balie Balie { get; set; }

        public Kok Kok { get; set; }

        List<Bestelling> bestellingenPerTafel = new List<Bestelling>();
        public int tafelnummer { get; set; }

        public Restaurant()
        {
            Balie balie = new Balie("Centrale Hal");
            Kok kok = new Kok(balie);
            GenereerBestellingenPerTafel(AANTALBESTELLINGEN, AANTALTAFELS);


        }

        public void start()
        {
            Balie balie = new Balie("Centrale Hal");
            Kok kok = new Kok(balie);

            balie.GenereerBestellingen(bestellingenPerTafel);

            if (bestellingenPerTafel.Count > 0)
            {

                kok.BereidMaaltijden();


            }
            Console.WriteLine($"Het aantal bestellingen is: {bestellingenPerTafel.Count}");


        }

        public void GenereerBestellingenPerTafel(int AANTALBESTELLINGEN, int AANTALTAFELS)
        {

            Console.WriteLine($"Er worden nu 20 bestellingen gegenereerd door methode Balie.GenereerBestellingen:");

            Bestelling bestelling;

            for (var i = 0; i < AANTALBESTELLINGEN; i++)
            {
             //  int bestelnummer = new Random().Next(1, AANTALBESTELLINGEN);
                 tafelnummer = new Random().Next(1, AANTALTAFELS);
              
                   bestelling = new Bestelling(i, tafelnummer);
                bestellingenPerTafel.Add(bestelling);
                Console.WriteLine($"Genereer bestelling {i} voor tafel {tafelnummer}");

            }
            Console.WriteLine($"Methode Balie.Genereerbestellingen is beeindigd. Maaltijden kunnen nu worden bereidt.");

        }




    }

 
}
