using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Persoonskenmerken
    {
        //Fields
        private int mobieleNummer;
        private float schoenmaat;
        private string haarKleur;

        public Persoonskenmerken(int mobieleNummer, float schoenmaat, string haarKleur)
        {
            this.mobieleNummer = mobieleNummer;
            this.schoenmaat = schoenmaat;
            this.haarKleur = haarKleur;
        }

        public void Kenmerken()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Mobiele nummer: {0}", this.mobieleNummer);
            Console.WriteLine("Mobiele nummer: {0}", this.haarKleur);
            Console.WriteLine("Mobiele nummer: {0}", this.schoenmaat);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
            // enz....
        }
    }
}
