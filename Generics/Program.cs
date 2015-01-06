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

            listMetGeheleGetallen.Add(100);
            listMetGeheleGetallen.Add(200);
            listMetGeheleGetallen.Add(300);
            listMetGeheleGetallen.Add(400);
            listMetGeheleGetallen.Add(500);

            string getallen = "";
            foreach (int getal in listMetGeheleGetallen)
            {
                getallen += getal.ToString() + " ";
            }

            Console.WriteLine("In de List<int> listMetGeheleGetallen zit het getal {0}", getallen);

            
            Console.ReadLine();
        }
    }
}
