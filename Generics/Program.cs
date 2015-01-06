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

            




            Console.ReadLine();
        }
    }
}
