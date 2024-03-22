using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{


    internal class Restaurant
    {
        public int AANTALTAFELS = 10;
        public int AANTALBESTELLINGEN = 20;
        public int MINIMALE_BEREIDINGSTIJD = 750;
        public int MAXIMALE_BEREIDINGSTIJD = 1500;
        public List<BestellingenPerTafel> bestellingenPerTafel { get; set; }

        public Restaurant()
        {
            Balie balie = new Balie("Centrale Hal");
            Kok kok = new Kok(balie);
            GenereerBestellingenPerTafel(AANTALBESTELLINGEN, AANTALTAFELS);
        }

        public void start()
        {
            Balie.GenereerBestellingen(bestellingenPerTafel);

            if (bestellingenPerTafel.Count > 0)
            {
              Kok.BereidMaaltijden();
            }
            Console.WriteLine("Het aantal bestellingen is:", bestellingenPerTafel.Count);

            
        }

        public void GenereerBestellingenPerTafel(int AANTALBESTELLINGEN, int AANTALTAFELS)
        {
            for (var i = 0; i < AANTALBESTELLINGEN; i++)
            {
                int randbereidtijd = new Random().Next(MINIMALE_BEREIDINGSTIJD, MAXIMALE_BEREIDINGSTIJD);
                int tafelnummer = new Random().Next(1, AANTALTAFELS);
                Bestelling bestelling = new Bestelling(randbereidtijd, tafelnummer);
                bestellingenPerTafel.Add(bestelling);
                 
            }
        }




    }

    public class BestellingenPerTafel
    {
        public BestellingenPerTafel()

        {


        }


    }
}
