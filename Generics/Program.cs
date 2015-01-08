using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Generics!";

            // We maken een object van de generieke klas List
            List<int> listMetGeheleGetallen;
            listMetGeheleGetallen = new List<int>();
            /*
            listMetGeheleGetallen.Add(100);
            listMetGeheleGetallen.Add(200);
            listMetGeheleGetallen.Add(300);
            listMetGeheleGetallen.Add(400);
            listMetGeheleGetallen.Add(500);
            */
            for (int i = 0; i < 400; i += 3)
            {
                listMetGeheleGetallen.Add(i);
            }

            string getallen = "";
            foreach (int getal in listMetGeheleGetallen)
            {
                getallen += getal.ToString() + " ";
            }

            Console.WriteLine("In de List<int> listMetGeheleGetallen zitten de getallen {0}", getallen);

            int totaal = 0;
            // Maak een for loop die alle getallen bij elkaar optelt in de list<int>
            for (int i = 0; i < listMetGeheleGetallen.Count; i++)
            {
                totaal += listMetGeheleGetallen[i];
            }
            Console.WriteLine("Het totaal is: {0}", totaal);
            
            //Maak een list<char>
            List<char> characterList = new List<char>();

            // Voeg een woord toe met add method (langer dan 23 characters)
            string woordLangerDan23Char = "Vrachtwagenachterwielventieldopjes";
            
            for (int i = 0; i < woordLangerDan23Char.Length; i++)
            {
               characterList.Add(woordLangerDan23Char[i]);
            }

            // Gebruik een foreach om het woord op het scherm te krijgen
            foreach (char letter in characterList)
            {
                Console.Write(letter);
            }

            Console.WriteLine("");

            // Maak een class persoonskenmerken met de fields, mobielnummer, schoenmaat, haarkleur.
            // en een method kenmerken() die al deze kenmerken afbeeld naar de console
            
            // Maak een List<persoonskenmerken> en vul deze met objecten van deze class
            List<Persoonskenmerken> persoonskenmerken = new List<Persoonskenmerken>();

            Persoonskenmerken pk1 = new Persoonskenmerken(0251273456, 9.5f, "grijs");
            Persoonskenmerken pk3;

            persoonskenmerken.Add(pk1);
            persoonskenmerken.Add(new Persoonskenmerken(0251347865, 6.0f, "Bruin"));
            persoonskenmerken.Add(pk3 = new Persoonskenmerken(030345321, 8.5f, "Blond"));

            // Roep van ieder object in de list de method kenmerken() aan met een foreach loop 

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            foreach(Persoonskenmerken pk in persoonskenmerken)
            {
                pk.Kenmerken();
            }

            Dictionary<string, int> telefoonboek;
            telefoonboek = new Dictionary<string, int>();

            telefoonboek.Add("Ruijter, A. de", 0251674210);
            telefoonboek.Add("Braak, M. ter", 0301234567);
            telefoonboek.Add("Telnekes, H.", 0201234321);
            telefoonboek.Add("Nooij, J.", 0402132435);
            telefoonboek.Add("Karsten, K.", 0351232435);

            int nummer = telefoonboek["Ruijter, A. de"];
            int nummer1 = telefoonboek["Nooij, J."];
            Console.WriteLine("Het opgeslagen nummer is: {0}", nummer1);

            string naam = "Nooij, J.";

            foreach (KeyValuePair<string, int> item in telefoonboek)
            {
                if ( item.Key != naam)
                {
                    Console.WriteLine("De naam is: {0} en het telefoonummer is: {1}", item.Key, item.Value);
                }
            }
            //telefoonboek.Remove(naam);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            for (int i = 0; i < telefoonboek.Count; i++)
            {
                if (telefoonboek.ElementAt(i).Key == naam)
                {
                    Console.WriteLine("Het record {0} met telefoonnummer {1} is verwijderd",
                                       telefoonboek.ElementAt(i).Key,
                                       telefoonboek.ElementAt(i).Value);
                    telefoonboek.Remove(telefoonboek.ElementAt(i).Key);
                }
                else
                {
                    Console.WriteLine("De naam is: {0} en het telefoonummer is: {1}", 
                                       telefoonboek.ElementAt(i).Key,
                                       telefoonboek.ElementAt(i).Value);
                }
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            
            Dictionary<int, string> getallenDictionary = new Dictionary<int, string>();

            getallenDictionary.Add(0, "nul");
            getallenDictionary.Add(1, "een");
            getallenDictionary.Add(2, "twee");
            getallenDictionary.Add(3, "drie");
            getallenDictionary.Add(4, "vier");
            getallenDictionary.Add(5, "vijf");
            getallenDictionary.Add(6, "zes");
            getallenDictionary.Add(7, "zeven");
            getallenDictionary.Add(8, "acht");
            getallenDictionary.Add(9, "negen");
            getallenDictionary.Add(10, "tien");
            //Enz... getallen 1 t/m 10

            foreach ( KeyValuePair<int, string> getal in getallenDictionary)
            {
                Console.WriteLine("Het getal {0} schrijf je zo: {1}", getal.Key, getal.Value);
            }

            // Koppel een naam aan een class persoonskenmerken met een dictionary
            // Geef deze weer met een foreach loop

            Dictionary<string, Persoonskenmerken> persoonsInfo;
            persoonsInfo = new Dictionary<string, Persoonskenmerken>();

            persoonsInfo.Add("Arjan", new Persoonskenmerken(0612324356, 9.5f, "grijs"));
            persoonsInfo.Add("Bert", new Persoonskenmerken(0654342312, 6.5f, "blond"));
            persoonsInfo.Add("Hans", new Persoonskenmerken(0698456787, 10.5f, "zwart"));
            persoonsInfo.Add("Harry", new Persoonskenmerken(0623435465, 14f, "bruin"));
            persoonsInfo.Add("Theo", new Persoonskenmerken(0634234567, 7.5f, "roze"));


            foreach (KeyValuePair<string, Persoonskenmerken> persoon in persoonsInfo)
            {
                
                Console.WriteLine("De persoon met voornaam {0} heeft: ", persoon.Key);
                Console.WriteLine("Mobiele nummer: " + persoon.Value.MobieleNummer );
                Console.WriteLine("Haarkleur: " + persoon.Value.Haarkleur);
                Console.WriteLine("Schoenmaat: " + persoon.Value.Schoenmaat);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            }

            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            OefenLijst<float> rapportCijfers = new OefenLijst<float>(10f);
            OefenLijst<string> boodschappenlijstje = new OefenLijst<string>("Bloemkool");
            OefenLijst<Persoonskenmerken> presentielijst = 
                new OefenLijst<Persoonskenmerken>(new Persoonskenmerken(01234565, 9.5f, "zwart"));

            rapportCijfers.Add(7.5f);
            boodschappenlijstje.Add("Spaghetti");

            foreach (float cijfer in rapportCijfers.Lijst)
            {
                Console.WriteLine("Cijfers is: {0}",  cijfer);
            }

            foreach (string boodschap in boodschappenlijstje.Lijst)
            {
                Console.WriteLine("Boodschap is: {0}", boodschap);
            }
                  
            
            Console.ReadLine();
        }
    }
}
