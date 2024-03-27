using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{
    public class Balie 
    {
       public List<Bestelling> Bestellingen = new List<Bestelling>();

       public List<Maaltijd> Maaltijden = new List<Maaltijd>();

        public int AANTALTAFELS = 10;


        public string BalieLocatie { get; set; }
        public int bestelnr { get; set; }
        public int tafelnummer { get; set; }



        public Balie(string balielocatie) 
        { 
        BalieLocatie = balielocatie;

      
        }

       public bool ErZijnNogBestellingen()
        {
            if (Bestellingen.Count == 0)
            {
                return false;
            }
            else 
                return true;
        }
        public bool ErZijnNogMaaltijden()
        {
            if (Maaltijden.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
       
        public void GenereerBestellingen(List<Bestelling> bestellingenPerTafel)
        {
            for (int i = 0; i < bestellingenPerTafel.Count; i++)
            {
                // ik heb hier dezelfde Random functie gebruikt als in Restaurant, maar volgens mij klopt dit niet
                //ik kom er alleen niet uit hoe ik het tafelnummer 

                tafelnummer = new Random().Next(1, AANTALTAFELS);
                Bestelling bestelling = new Bestelling(i, tafelnummer);
                Console.WriteLine($"Kok bereidt maaltijd {i} voor tafel {tafelnummer}");


                PlaatsBestelling(bestelling);

            }
        }



        public void PlaatsBestelling(Bestelling b)
        {
            Bestellingen.Add(b);

        }


        public int ToonAantalBestellingen()
        {
            return Bestellingen.Count;
        }
        public int ToonAantalMaaltijden()
        {
            return Maaltijden.Count;
        }

        public void PlaatsMaaltijd(Maaltijd m)
        {
            Maaltijden.Add(m);

        }
        public Bestelling PakBestelling()
        {
            var bestelling = Bestellingen.FirstOrDefault();

            Bestellingen.Remove(bestelling);

            return bestelling;
        }
    }

}
