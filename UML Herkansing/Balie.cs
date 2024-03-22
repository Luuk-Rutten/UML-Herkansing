using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace UML_Herkansing
{
    internal class Balie 
    {
       static List<Bestelling> Bestellingen = new List<Bestelling>();
       static List<Maaltijd> Maaltijden = new List<Maaltijd>();
       // static List<BestellingenPerTafel> bestellingenPerTafel = new List<BestellingenPerTafel>();


       public string BalieLocatie { get; set; }
        public static int bestelnr { get; set; }
        public static int tafelnr { get; set; }



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
       
        public static void GenereerBestellingen(List<BestellingenPerTafel> bestellingenPerTafel)
        {
            for (int i = 0; i < bestellingenPerTafel.Count; i++)
            {
               Bestelling bestelling = new Bestelling(bestelnr, tafelnr);
                PlaatsBestelling(bestelling);

              Console.WriteLine(bestellingenPerTafel[i]);
            }
        }

        public void PakBestelling()
        {
           var bestelling = Bestellingen.FirstOrDefault();
            Bestellingen.Remove(bestelling);
        }

        public static void PlaatsBestelling(Bestelling b)
        {
            Bestellingen.Add(b);    
        }
        public static void PlaatsMaaltijd(Maaltijd m)
        {
            Maaltijden.Add(m);
        }

        public int ToonAantalBestellingen()
        {
            return Bestellingen.Count;
        }
        public int ToonAantalMaaltijden()
        {
            return Maaltijden.Count;
        }
    }

}
