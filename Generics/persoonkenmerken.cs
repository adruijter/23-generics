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
            //enzz..
        }

        public void Kenmerken()
        {
            Console.WriteLine("Mobiele nummer: {0}", this.mobieleNummer);
            // enz....
        }
    }
}
